namespace Gmina.Body
{
    partial class SingleEvent
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
            this.BackButton = new Gmina.ButtonRounded();
            this.EventPicture = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EventPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BackButton.Location = new System.Drawing.Point(695, 31);
            this.BackButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 60);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Powrót";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EventPicture
            // 
            this.EventPicture.Image = global::Gmina.Properties.Resources.image;
            this.EventPicture.Location = new System.Drawing.Point(57, 113);
            this.EventPicture.Name = "EventPicture";
            this.EventPicture.Size = new System.Drawing.Size(316, 238);
            this.EventPicture.TabIndex = 17;
            this.EventPicture.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(433, 113);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(412, 238);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Tytuł";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(57, 380);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(774, 281);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Opis";
            // 
            // SingleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.EventPicture);
            this.Controls.Add(this.BackButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SingleEvent";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.SingleEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonRounded BackButton;
        private PictureBox EventPicture;
        private Label lblTitle;
        private Label lblDescription;
    }
}
