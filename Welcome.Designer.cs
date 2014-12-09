namespace MyNoteBook_v1._0
{
    partial class WelcomeWindow
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
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoEllipsis = true;
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WelcomeMessageLabel.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.WelcomeMessageLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(620, 448);
            this.WelcomeMessageLabel.TabIndex = 0;
            this.WelcomeMessageLabel.Text = "Welcome \r\nto \r\nMyNoteBook\r\n v1.0";
            this.WelcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(683, 528);
            this.ControlBox = false;
            this.Controls.Add(this.WelcomeMessageLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "WelcomeWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessageLabel;
    }
}