namespace RemotingTask.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Send_Button = new System.Windows.Forms.Button();
            this.msg_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(349, 193);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 0;
            this.Send_Button.Text = "Gönder";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // msg_textbox
            // 
            this.msg_textbox.Location = new System.Drawing.Point(337, 156);
            this.msg_textbox.Name = "msg_textbox";
            this.msg_textbox.Size = new System.Drawing.Size(100, 22);
            this.msg_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sunucuya mesaj gönder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(354, 261);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(70, 16);
            this.responseLabel.TabIndex = 3;
            this.responseLabel.Text = "Response";
            this.responseLabel.Visible = false;
            this.responseLabel.Click += new System.EventHandler(this.responseLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msg_textbox);
            this.Controls.Add(this.Send_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox msg_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label responseLabel;
    }
}

