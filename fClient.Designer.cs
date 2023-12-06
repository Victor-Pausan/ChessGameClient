
namespace ChessGame
{
    partial class fClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnConect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 581);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Address:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(274, 578);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(182, 22);
            this.tbAddress.TabIndex = 10;
            this.tbAddress.Text = "127.0.0.1";
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(189, 444);
            this.btnConect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(267, 46);
            this.btnConect.TabIndex = 9;
            this.btnConect.Text = "Start";
            this.btnConect.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(25, 24);
            this.textBox1.TabIndex = 8;
            // 
            // tbDate
            // 
            this.tbDate.Enabled = false;
            this.tbDate.Location = new System.Drawing.Point(46, 15);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(36, 22);
            this.tbDate.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(13, 45);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(36, 25);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 512);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(267, 46);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(152)))), ((int)(((byte)(51)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Vladimir Script", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(158, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(337, 99);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Chess Game";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChessGame.Properties.Resources.white_knight;
            this.pictureBox1.Location = new System.Drawing.Point(189, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // fClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(152)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(641, 616);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbDate);
            this.Name = "fClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fClient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}