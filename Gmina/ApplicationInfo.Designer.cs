using Gmina.Body;

namespace Gmina
{
    partial class ApplicationInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplicationsList = new System.Windows.Forms.DataGridView();
            this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartość = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akceptButton = new Gmina.ButtonRounded();
            this.correntButton = new Gmina.ButtonRounded();
            this.rejectButton = new Gmina.ButtonRounded();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informacje o wniosku";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ApplicationsList);
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 457);
            this.panel1.TabIndex = 8;
            // 
            // ApplicationsList
            // 
            this.ApplicationsList.AllowUserToAddRows = false;
            this.ApplicationsList.AllowUserToDeleteRows = false;
            this.ApplicationsList.AllowUserToResizeRows = false;
            this.ApplicationsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.ApplicationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwa,
            this.wartość});
            this.ApplicationsList.Location = new System.Drawing.Point(0, 3);
            this.ApplicationsList.Name = "ApplicationsList";
            this.ApplicationsList.ReadOnly = true;
            this.ApplicationsList.RowHeadersVisible = false;
            this.ApplicationsList.RowTemplate.Height = 25;
            this.ApplicationsList.Size = new System.Drawing.Size(520, 550);
            this.ApplicationsList.TabIndex = 6;
            this.ApplicationsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicationsList_CellContentClick);
            // 
            // nazwa
            // 
            this.nazwa.HeaderText = "nazwa";
            this.nazwa.Name = "nazwa";
            this.nazwa.ReadOnly = true;
            this.nazwa.Width = 270;
            // 
            // wartość
            // 
            this.wartość.HeaderText = "wartość";
            this.wartość.Name = "wartość";
            this.wartość.ReadOnly = true;
            this.wartość.Width = 270;
            // 
            // akceptButton
            // 
            this.akceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.akceptButton.FlatAppearance.BorderSize = 0;
            this.akceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.akceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.akceptButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.akceptButton.Location = new System.Drawing.Point(12, 82);
            this.akceptButton.Name = "akceptButton";
            this.akceptButton.Size = new System.Drawing.Size(150, 40);
            this.akceptButton.TabIndex = 9;
            this.akceptButton.Text = "Przyjęty";
            this.akceptButton.UseVisualStyleBackColor = false;
            this.akceptButton.Click += new System.EventHandler(this.akceptButton_Click);
            // 
            // correntButton
            // 
            this.correntButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.correntButton.FlatAppearance.BorderSize = 0;
            this.correntButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.correntButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.correntButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.correntButton.Location = new System.Drawing.Point(196, 82);
            this.correntButton.Name = "correntButton";
            this.correntButton.Size = new System.Drawing.Size(150, 40);
            this.correntButton.TabIndex = 10;
            this.correntButton.Text = "Do poprawy";
            this.correntButton.UseVisualStyleBackColor = false;
            this.correntButton.Click += new System.EventHandler(this.correntButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rejectButton.FlatAppearance.BorderSize = 0;
            this.rejectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rejectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rejectButton.Location = new System.Drawing.Point(370, 82);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(150, 40);
            this.rejectButton.TabIndex = 11;
            this.rejectButton.Text = "Odrzucony";
            this.rejectButton.UseVisualStyleBackColor = false;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // ApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(542, 522);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.correntButton);
            this.Controls.Add(this.akceptButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ApplicationInfo";
            this.Text = "ApplicationInfo";
            this.Load += new System.EventHandler(this.ApplicationInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView ApplicationsList;
        private DataGridViewTextBoxColumn nazwa;
        private DataGridViewTextBoxColumn wartość;
        private ButtonRounded akceptButton;
        private ButtonRounded correntButton;
        private ButtonRounded rejectButton;
    }
}