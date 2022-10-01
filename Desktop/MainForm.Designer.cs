namespace Desktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.NameBox = new System.Windows.Forms.TextBox();
      this.TextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.Send = new System.Windows.Forms.Button();
      this.Set = new System.Windows.Forms.Button();
      this.Get = new System.Windows.Forms.Button();
      this.Disconnect = new System.Windows.Forms.Button();
      this.StateConnection = new System.Windows.Forms.Label();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.ChatBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // NameBox
      // 
      this.NameBox.Location = new System.Drawing.Point(60, 65);
      this.NameBox.Name = "NameBox";
      this.NameBox.Size = new System.Drawing.Size(158, 23);
      this.NameBox.TabIndex = 0;
      // 
      // TextBox
      // 
      this.TextBox.Location = new System.Drawing.Point(61, 123);
      this.TextBox.Multiline = true;
      this.TextBox.Name = "TextBox";
      this.TextBox.Size = new System.Drawing.Size(158, 108);
      this.TextBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(5, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(5, 123);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Text";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(5, 20);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 17);
      this.label3.TabIndex = 4;
      this.label3.Text = "State";
      // 
      // Send
      // 
      this.Send.BackColor = System.Drawing.Color.LightGray;
      this.Send.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.Send.FlatAppearance.BorderSize = 0;
      this.Send.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Send.Location = new System.Drawing.Point(143, 237);
      this.Send.Name = "Send";
      this.Send.Size = new System.Drawing.Size(75, 23);
      this.Send.TabIndex = 5;
      this.Send.Text = "Send";
      this.Send.UseVisualStyleBackColor = false;
      this.Send.Click += new System.EventHandler(this.Send_Click);
      // 
      // Set
      // 
      this.Set.BackColor = System.Drawing.Color.LightGray;
      this.Set.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.Set.FlatAppearance.BorderSize = 0;
      this.Set.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Set.Location = new System.Drawing.Point(144, 94);
      this.Set.Name = "Set";
      this.Set.Size = new System.Drawing.Size(75, 23);
      this.Set.TabIndex = 6;
      this.Set.Text = "Set";
      this.Set.UseVisualStyleBackColor = false;
      this.Set.Click += new System.EventHandler(this.Set_Click);
      // 
      // Get
      // 
      this.Get.BackColor = System.Drawing.Color.LightGray;
      this.Get.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.Get.FlatAppearance.BorderSize = 0;
      this.Get.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Get.Location = new System.Drawing.Point(61, 94);
      this.Get.Name = "Get";
      this.Get.Size = new System.Drawing.Size(75, 23);
      this.Get.TabIndex = 7;
      this.Get.Text = "Get";
      this.Get.UseVisualStyleBackColor = false;
      this.Get.Click += new System.EventHandler(this.Get_Click);
      // 
      // Disconnect
      // 
      this.Disconnect.BackColor = System.Drawing.Color.LightGray;
      this.Disconnect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.Disconnect.FlatAppearance.BorderSize = 0;
      this.Disconnect.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Disconnect.Location = new System.Drawing.Point(144, 20);
      this.Disconnect.Name = "Disconnect";
      this.Disconnect.Size = new System.Drawing.Size(75, 23);
      this.Disconnect.TabIndex = 8;
      this.Disconnect.Text = "Connect";
      this.Disconnect.UseVisualStyleBackColor = false;
      this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
      // 
      // StateConnection
      // 
      this.StateConnection.AutoSize = true;
      this.StateConnection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.StateConnection.ForeColor = System.Drawing.Color.Red;
      this.StateConnection.Location = new System.Drawing.Point(60, 22);
      this.StateConnection.Name = "StateConnection";
      this.StateConnection.Size = new System.Drawing.Size(86, 17);
      this.StateConnection.TabIndex = 9;
      this.StateConnection.Text = "Disconnected";
      // 
      // ChatBox
      // 
      this.ChatBox.Enabled = false;
      this.ChatBox.Location = new System.Drawing.Point(225, 22);
      this.ChatBox.Name = "ChatBox";
      this.ChatBox.Size = new System.Drawing.Size(563, 416);
      this.ChatBox.TabIndex = 10;
      this.ChatBox.Text = "";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ChatBox);
      this.Controls.Add(this.StateConnection);
      this.Controls.Add(this.Disconnect);
      this.Controls.Add(this.Get);
      this.Controls.Add(this.Set);
      this.Controls.Add(this.Send);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TextBox);
      this.Controls.Add(this.NameBox);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox NameBox;
    private System.Windows.Forms.TextBox TextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button Send;
    private System.Windows.Forms.Button Set;
    private System.Windows.Forms.Button Get;
    private System.Windows.Forms.Button Disconnect;
    private System.Windows.Forms.Label StateConnection;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.RichTextBox ChatBox;
  }
}