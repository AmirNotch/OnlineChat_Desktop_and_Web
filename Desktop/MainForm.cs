using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace Desktop
{
  public partial class MainForm : Form
  {
    private readonly HubConnection _hubConnection;

    public MainForm()
    {
      InitializeComponent();

      _hubConnection = new HubConnectionBuilder()
          .WithUrl("https://localhost:44390/messages")
          .WithAutomaticReconnect()
          .Build();

      _hubConnection.On<NewMessage>("Send", message =>
      {
        AppendTextToTextBox(message.Sender, message.Text, Color.Black);
      });

      _hubConnection.Closed += error =>
      {
        MessageBox.Show($"Connection Closed, {error.Message}");
        return Task.CompletedTask;
      };

      _hubConnection.Reconnected += id =>
      {
        MessageBox.Show($"Connection reconnected with id: {id}");
        return Task.CompletedTask;
      };

      _hubConnection.Reconnecting += error =>
      {
        MessageBox.Show($"Connection reconnecting. {error.Message}");
        return Task.CompletedTask;
      };
    }

    private void AppendTextToTextBox(string sender, string text, Color color)
    {
      ChatBox.SelectionStart = ChatBox.TextLength;
      ChatBox.SelectionLength = 0;
      ChatBox.SelectionColor = color;
      ChatBox.AppendText(string.Format("Author: {0}{2}Text: {1}{2}{2}", sender, text, Environment.NewLine));
      ChatBox.SelectionColor = ChatBox.ForeColor;
    }

    private async void Disconnect_Click(object sender, EventArgs e)
    {
      if (_hubConnection.State == HubConnectionState.Disconnected)
      {
        try
        {
          await _hubConnection.StartAsync();
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message);
        }

        if (_hubConnection.State == HubConnectionState.Connected)
        {
          Disconnect.Text = "Disconnect";
          StateConnection.ForeColor = Color.Green;
          StateConnection.Text = "Connected";
        }
      }
      else if (_hubConnection.State == HubConnectionState.Connected)
      {
        await _hubConnection.StopAsync();
        Disconnect.Text = "Connect";
        StateConnection.ForeColor = Color.Red;
        StateConnection.Text = "Disconnected";
      }
    }

    private async void Set_Click(object sender, EventArgs e)
    {
      if (_hubConnection.State == HubConnectionState.Connected)
      {
        try
        {
          await _hubConnection.SendAsync("SetMyName", NameBox.Text);
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message);
        }
      }
    }

    private async void Get_Click(object sender, EventArgs e)
    {
      if (_hubConnection.State == HubConnectionState.Connected)
      {
        try
        {
          var name = await _hubConnection.InvokeAsync<string>("GetMyName");

          if (string.IsNullOrWhiteSpace(name))
          {
            NameBox.Text = "Anonymous";
          }
          else
          {
            NameBox.Text = name;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
    }

    private async void Send_Click(object sender, EventArgs e)
    {
      if (_hubConnection.State == HubConnectionState.Connected)
      {
        var message = new Message
        {
          Text = TextBox.Text
        };

        try
        {
          await _hubConnection.SendAsync("SendMessage", message);
          AppendTextToTextBox("Me", message.Text, Color.Green);
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message);
        }
        finally
        {
          TextBox.Clear();
        }
      }
    }
  }
}