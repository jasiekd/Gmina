﻿namespace Gmina.Body
{
    partial class ClerkAddEvent
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
            this.AddEventLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EventTitleText = new System.Windows.Forms.TextBox();
            this.EventTitleLabel = new System.Windows.Forms.Label();
            this.EventDescription = new System.Windows.Forms.TextBox();
            this.EventDescriptionLabel = new System.Windows.Forms.Label();
            this.EventShortDescriptionLabel = new System.Windows.Forms.Label();
            this.EventShortDescription = new System.Windows.Forms.TextBox();
            this.EventImageLabel = new System.Windows.Forms.Label();
            this.AddEventButton = new Gmina.ButtonRounded();
            this.imgURLTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEventLabel
            // 
            this.AddEventLabel.AutoSize = true;
            this.AddEventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEventLabel.ForeColor = System.Drawing.Color.White;
            this.AddEventLabel.Location = new System.Drawing.Point(246, 17);
            this.AddEventLabel.Name = "AddEventLabel";
            this.AddEventLabel.Size = new System.Drawing.Size(270, 37);
            this.AddEventLabel.TabIndex = 8;
            this.AddEventLabel.Text = "Dodaj wydarzenie";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.53646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.46354F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.EventTitleText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EventTitleLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EventDescription, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.EventDescriptionLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.EventShortDescriptionLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EventShortDescription, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EventImageLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AddEventButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.imgURLTextBox, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 628);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // EventTitleText
            // 
            this.EventTitleText.Location = new System.Drawing.Point(110, 23);
            this.EventTitleText.Name = "EventTitleText";
            this.EventTitleText.Size = new System.Drawing.Size(537, 23);
            this.EventTitleText.TabIndex = 0;
            // 
            // EventTitleLabel
            // 
            this.EventTitleLabel.AutoSize = true;
            this.EventTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventTitleLabel.Location = new System.Drawing.Point(110, 0);
            this.EventTitleLabel.Name = "EventTitleLabel";
            this.EventTitleLabel.Size = new System.Drawing.Size(101, 15);
            this.EventTitleLabel.TabIndex = 1;
            this.EventTitleLabel.Text = "Tytuł wydarzenia";
            // 
            // EventDescription
            // 
            this.EventDescription.Location = new System.Drawing.Point(110, 179);
            this.EventDescription.Multiline = true;
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.Size = new System.Drawing.Size(537, 285);
            this.EventDescription.TabIndex = 3;
            // 
            // EventDescriptionLabel
            // 
            this.EventDescriptionLabel.AutoSize = true;
            this.EventDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventDescriptionLabel.Location = new System.Drawing.Point(110, 157);
            this.EventDescriptionLabel.Name = "EventDescriptionLabel";
            this.EventDescriptionLabel.Size = new System.Drawing.Size(102, 15);
            this.EventDescriptionLabel.TabIndex = 2;
            this.EventDescriptionLabel.Text = "Treść wydarzenia";
            // 
            // EventShortDescriptionLabel
            // 
            this.EventShortDescriptionLabel.AutoSize = true;
            this.EventShortDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventShortDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventShortDescriptionLabel.Location = new System.Drawing.Point(110, 50);
            this.EventShortDescriptionLabel.Name = "EventShortDescriptionLabel";
            this.EventShortDescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.EventShortDescriptionLabel.TabIndex = 6;
            this.EventShortDescriptionLabel.Text = "Krótki opis";
            this.EventShortDescriptionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EventShortDescription
            // 
            this.EventShortDescription.Location = new System.Drawing.Point(110, 73);
            this.EventShortDescription.Multiline = true;
            this.EventShortDescription.Name = "EventShortDescription";
            this.EventShortDescription.Size = new System.Drawing.Size(537, 81);
            this.EventShortDescription.TabIndex = 7;
            // 
            // EventImageLabel
            // 
            this.EventImageLabel.AutoSize = true;
            this.EventImageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventImageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventImageLabel.Location = new System.Drawing.Point(110, 467);
            this.EventImageLabel.Name = "EventImageLabel";
            this.EventImageLabel.Size = new System.Drawing.Size(91, 15);
            this.EventImageLabel.TabIndex = 4;
            this.EventImageLabel.Text = "Link do zdjęcia:";
            // 
            // AddEventButton
            // 
            this.AddEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.AddEventButton.FlatAppearance.BorderSize = 0;
            this.AddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEventButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEventButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.AddEventButton.Location = new System.Drawing.Point(110, 542);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(190, 70);
            this.AddEventButton.TabIndex = 8;
            this.AddEventButton.Text = "Dodaj wydarzenie";
            this.AddEventButton.UseVisualStyleBackColor = false;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // imgURLTextBox
            // 
            this.imgURLTextBox.Location = new System.Drawing.Point(110, 492);
            this.imgURLTextBox.Name = "imgURLTextBox";
            this.imgURLTextBox.Size = new System.Drawing.Size(537, 23);
            this.imgURLTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 586);
            this.panel1.TabIndex = 10;
            // 
            // ClerkAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddEventLabel);
            this.Name = "ClerkAddEvent";
            this.Size = new System.Drawing.Size(788, 661);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddEventLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox EventTitleText;
        private Label EventTitleLabel;
        private Label EventDescriptionLabel;
        private TextBox EventDescription;
        private Label EventImageLabel;
        private Panel panel1;
        private Label EventShortDescriptionLabel;
        private TextBox EventShortDescription;
        private ButtonRounded AddEventButton;
        private TextBox imgURLTextBox;
    }
}
