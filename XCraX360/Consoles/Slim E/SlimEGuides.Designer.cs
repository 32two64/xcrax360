namespace XCraX360.Consoles.Slim_E
{
    partial class SlimEGuides
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlimEGuides));
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Black;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(694, 396);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "   Slim E Guides";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.Black;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(392, 347);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = true;
            this.flatButton1.Size = new System.Drawing.Size(254, 45);
            this.flatButton1.TabIndex = 7;
            this.flatButton1.Text = "Teardown Guide";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.Black;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(44, 347);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = true;
            this.flatButton2.Size = new System.Drawing.Size(254, 45);
            this.flatButton2.TabIndex = 6;
            this.flatButton2.Text = "Hard Modding (RGH)";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.FlatButton2_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 57);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(644, 105);
            this.flatLabel1.TabIndex = 5;
            this.flatLabel1.Text = resources.GetString("flatLabel1.Text");
            // 
            // SlimEGuides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 396);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlimEGuides";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlimEGuides";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatLabel flatLabel1;
    }
}