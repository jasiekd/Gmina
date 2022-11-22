namespace Gmina.Body
{
    partial class ListItem
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
        
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EventPicture = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EventPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // EventPicture
            // 
            this.EventPicture.Image = global::Gmina.Properties.Resources.image;
            this.EventPicture.Location = new System.Drawing.Point(41, 31);
            this.EventPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EventPicture.Name = "EventPicture";
            this.EventPicture.Size = new System.Drawing.Size(178, 158);
            this.EventPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EventPicture.TabIndex = 0;
            this.EventPicture.TabStop = false;
            this.EventPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItem_MouseClick);
            this.EventPicture.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.EventPicture.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(261, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(541, 84);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Opis";
            this.lblDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItem_MouseClick);
            this.lblDescription.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lblDescription.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(261, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(541, 62);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tytuł";
            this.lblTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItem_MouseClick);
            this.lblTitle.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.EventPicture);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(870, 221);
            this.Load += new System.EventHandler(this.ListItem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItem_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ListItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.EventPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EventPicture;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
    }
}
