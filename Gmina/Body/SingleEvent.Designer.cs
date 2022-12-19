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
            this.BackButton.Location = new System.Drawing.Point(608, 23);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(131, 45);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Powrót";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EventPicture
            // 
            this.EventPicture.Image = global::Gmina.Properties.Resources.image;
            this.EventPicture.Location = new System.Drawing.Point(50, 85);
            this.EventPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventPicture.Name = "EventPicture";
            this.EventPicture.Size = new System.Drawing.Size(276, 178);
            this.EventPicture.TabIndex = 17;
            this.EventPicture.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(379, 85);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 178);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Tytuł";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(50, 285);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(677, 211);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Opis";
            // 
            // SingleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.EventPicture);
            this.Controls.Add(this.BackButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SingleEvent";
            this.Size = new System.Drawing.Size(788, 525);
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
