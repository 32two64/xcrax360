namespace XCraX360
{
    partial class Form1
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formSkin1.Controls.Add(this.pictureBox1);
            this.formSkin1.Controls.Add(this.flatTextBox1);
            this.formSkin1.Controls.Add(this.flatButton3);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Black;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(578, 408);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "   XCraX360";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.Black;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(12, 191);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = true;
            this.flatButton1.Size = new System.Drawing.Size(140, 81);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "Utilities";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.Black;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(12, 82);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = true;
            this.flatButton2.Size = new System.Drawing.Size(140, 81);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Guides";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.FlatButton2_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.Black;
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(12, 294);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = true;
            this.flatButton3.Size = new System.Drawing.Size(140, 81);
            this.flatButton3.TabIndex = 3;
            this.flatButton3.Text = "Exit";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.FlatButton3_Click);
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(225, 82);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = true;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = true;
            this.flatTextBox1.Size = new System.Drawing.Size(321, 293);
            this.flatTextBox1.TabIndex = 4;
            this.flatTextBox1.Text = "Welcome to XCraX360! Select an option to get started.";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pictureBox1.Image = global::XCraX360.Properties.Resources.Corona;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 408);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

