namespace TabletSoftware
{
    partial class FormClock
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
            this.lblClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClock.Font = new System.Drawing.Font("MS UI Gothic", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblClock.ForeColor = System.Drawing.Color.Gray;
            this.lblClock.Location = new System.Drawing.Point(0, 0);
            this.lblClock.Margin = new System.Windows.Forms.Padding(0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(1904, 1161);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "HH:mm:ss";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1161);
            this.Controls.Add(this.lblClock);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormClock";
            this.Text = "FormClock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormClock_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
    }
}