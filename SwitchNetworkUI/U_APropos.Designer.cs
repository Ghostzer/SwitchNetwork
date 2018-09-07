namespace SwitchNetworkUI
{
    partial class U_APropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U_APropos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_nick = new System.Windows.Forms.Label();
            this.Lbl_url = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_nick
            // 
            this.Lbl_nick.AutoSize = true;
            this.Lbl_nick.Location = new System.Drawing.Point(99, 200);
            this.Lbl_nick.Name = "Lbl_nick";
            this.Lbl_nick.Size = new System.Drawing.Size(49, 13);
            this.Lbl_nick.TabIndex = 1;
            this.Lbl_nick.Text = "Ghostzer";
            // 
            // Lbl_url
            // 
            this.Lbl_url.ActiveLinkColor = System.Drawing.Color.Gray;
            this.Lbl_url.AutoSize = true;
            this.Lbl_url.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_url.Location = new System.Drawing.Point(63, 217);
            this.Lbl_url.Name = "Lbl_url";
            this.Lbl_url.Size = new System.Drawing.Size(121, 13);
            this.Lbl_url.TabIndex = 2;
            this.Lbl_url.TabStop = true;
            this.Lbl_url.Text = "http://ghostzer.github.io";
            this.Lbl_url.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // U_APropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 246);
            this.Controls.Add(this.Lbl_url);
            this.Controls.Add(this.Lbl_nick);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "U_APropos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "À propos";
            this.Load += new System.EventHandler(this.U_APropos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_nick;
        private System.Windows.Forms.LinkLabel Lbl_url;
    }
}