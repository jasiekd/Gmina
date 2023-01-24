namespace Gmina.Body
{
    partial class ElectionOrganization
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
            this.label1 = new System.Windows.Forms.Label();
            this.electionTitle = new System.Windows.Forms.TextBox();
            this.electionDate = new System.Windows.Forms.DateTimePicker();
            this.standardTypeRadio = new System.Windows.Forms.RadioButton();
            this.specialTypeRadio = new System.Windows.Forms.RadioButton();
            this.listPanel = new System.Windows.Forms.Panel();
            this.addElementText = new System.Windows.Forms.TextBox();
            this.addButton = new Gmina.ButtonRounded();
            this.sendButton = new Gmina.ButtonRounded();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(207, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organizowanie wyborów";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // electionTitle
            // 
            this.electionTitle.Location = new System.Drawing.Point(186, 106);
            this.electionTitle.Name = "electionTitle";
            this.electionTitle.Size = new System.Drawing.Size(422, 23);
            this.electionTitle.TabIndex = 2;
            // 
            // electionDate
            // 
            this.electionDate.Location = new System.Drawing.Point(186, 159);
            this.electionDate.Name = "electionDate";
            this.electionDate.Size = new System.Drawing.Size(422, 23);
            this.electionDate.TabIndex = 3;
            // 
            // standardTypeRadio
            // 
            this.standardTypeRadio.AutoSize = true;
            this.standardTypeRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.standardTypeRadio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.standardTypeRadio.Location = new System.Drawing.Point(186, 199);
            this.standardTypeRadio.Name = "standardTypeRadio";
            this.standardTypeRadio.Size = new System.Drawing.Size(93, 19);
            this.standardTypeRadio.TabIndex = 4;
            this.standardTypeRadio.TabStop = true;
            this.standardTypeRadio.Text = "Obywatelski";
            this.standardTypeRadio.UseVisualStyleBackColor = true;
            // 
            // specialTypeRadio
            // 
            this.specialTypeRadio.AutoSize = true;
            this.specialTypeRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialTypeRadio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.specialTypeRadio.Location = new System.Drawing.Point(339, 199);
            this.specialTypeRadio.Name = "specialTypeRadio";
            this.specialTypeRadio.Size = new System.Drawing.Size(82, 19);
            this.specialTypeRadio.TabIndex = 5;
            this.specialTypeRadio.TabStop = true;
            this.specialTypeRadio.Text = "Urzędowy";
            this.specialTypeRadio.UseVisualStyleBackColor = true;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(138)))));
            this.listPanel.Location = new System.Drawing.Point(186, 273);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(422, 231);
            this.listPanel.TabIndex = 1;
            // 
            // addElementText
            // 
            this.addElementText.Location = new System.Drawing.Point(186, 236);
            this.addElementText.Name = "addElementText";
            this.addElementText.Size = new System.Drawing.Size(316, 23);
            this.addElementText.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Location = new System.Drawing.Point(508, 236);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 31);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sendButton.Location = new System.Drawing.Point(186, 510);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(150, 40);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Zapisz i wyślij";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(186, 88);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(31, 15);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(186, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(184, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Typ";
            // 
            // ElectionOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addElementText);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.specialTypeRadio);
            this.Controls.Add(this.standardTypeRadio);
            this.Controls.Add(this.electionDate);
            this.Controls.Add(this.electionTitle);
            this.Controls.Add(this.label1);
            this.Name = "ElectionOrganization";
            this.Size = new System.Drawing.Size(788, 656);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox electionTitle;
        private DateTimePicker electionDate;
        private RadioButton standardTypeRadio;
        private RadioButton specialTypeRadio;
        private Panel listPanel;
        private TextBox addElementText;
        private ButtonRounded addButton;
        private ButtonRounded sendButton;
        private List<Panel> listOption = new List<Panel>();
        private List<String> listOptionString = new List<String>();
        private Label titleLabel;
        private Label label2;
        private Label label3;
    }
}
