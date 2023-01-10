namespace Gmina.Body
{
    partial class ElectionPage
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
            this.CandidatesList = new System.Windows.Forms.DataGridView();
            this.inhabitantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhabitantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhabitantSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhabitantBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vote = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CandidatesList
            // 
            this.CandidatesList.AllowUserToAddRows = false;
            this.CandidatesList.AllowUserToDeleteRows = false;
            this.CandidatesList.AllowUserToResizeRows = false;
            this.CandidatesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.CandidatesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CandidatesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inhabitantID,
            this.inhabitantName,
            this.inhabitantSurname,
            this.inhabitantBirthday,
            this.vote});
            this.CandidatesList.Location = new System.Drawing.Point(3, 3);
            this.CandidatesList.MinimumSize = new System.Drawing.Size(788, 450);
            this.CandidatesList.Name = "CandidatesList";
            this.CandidatesList.ReadOnly = true;
            this.CandidatesList.RowHeadersVisible = false;
            this.CandidatesList.RowHeadersWidth = 51;
            this.CandidatesList.RowTemplate.Height = 25;
            this.CandidatesList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CandidatesList.Size = new System.Drawing.Size(835, 450);
            this.CandidatesList.TabIndex = 7;
            this.CandidatesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CandidatesList_CellContentClick);
            // 
            // inhabitantID
            // 
            this.inhabitantID.HeaderText = "ID";
            this.inhabitantID.MinimumWidth = 6;
            this.inhabitantID.Name = "inhabitantID";
            this.inhabitantID.ReadOnly = true;
            this.inhabitantID.Width = 50;
            // 
            // inhabitantName
            // 
            this.inhabitantName.HeaderText = "Imie";
            this.inhabitantName.MinimumWidth = 6;
            this.inhabitantName.Name = "inhabitantName";
            this.inhabitantName.ReadOnly = true;
            this.inhabitantName.Width = 250;
            // 
            // inhabitantSurname
            // 
            this.inhabitantSurname.HeaderText = "Nazwisko";
            this.inhabitantSurname.MinimumWidth = 6;
            this.inhabitantSurname.Name = "inhabitantSurname";
            this.inhabitantSurname.ReadOnly = true;
            this.inhabitantSurname.Width = 143;
            // 
            // inhabitantBirthday
            // 
            this.inhabitantBirthday.HeaderText = "Data urodzenia";
            this.inhabitantBirthday.MinimumWidth = 6;
            this.inhabitantBirthday.Name = "inhabitantBirthday";
            this.inhabitantBirthday.ReadOnly = true;
            this.inhabitantBirthday.Width = 200;
            // 
            // vote
            // 
            this.vote.HeaderText = "Zagłosuj";
            this.vote.MinimumWidth = 6;
            this.vote.Name = "vote";
            this.vote.ReadOnly = true;
            this.vote.Text = "Zagłosuj";
            this.vote.ToolTipText = "Zagłosuj";
            this.vote.UseColumnTextForButtonValue = true;
            this.vote.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(360, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Głosowania";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.CandidatesList);
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 413);
            this.panel1.TabIndex = 9;
            // 
            // ElectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(859, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ElectionPage";
            this.Text = "ElectionPage";
            this.Load += new System.EventHandler(this.ElectionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private List<ButtonRounded> optionButtonList;
        private DataGridView CandidatesList;
        private DataGridViewTextBoxColumn inhabitantID;
        private DataGridViewTextBoxColumn inhabitantName;
        private DataGridViewTextBoxColumn inhabitantSurname;
        private DataGridViewTextBoxColumn inhabitantBirthday;
        private DataGridViewButtonColumn vote;
        private Label label1;
        private Panel panel1;
    }
}