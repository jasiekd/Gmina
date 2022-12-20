namespace Gmina.Body
{
    partial class ElectionsBody
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
            this.CandidatesList = new System.Windows.Forms.DataGridView();
            this.electionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseElection = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybory";
            // 
            // CandidatesList
            // 
            this.CandidatesList.AllowUserToAddRows = false;
            this.CandidatesList.AllowUserToDeleteRows = false;
            this.CandidatesList.AllowUserToResizeRows = false;
            this.CandidatesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.CandidatesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.electionID,
            this.electionName,
            this.chooseElection});
            this.CandidatesList.Location = new System.Drawing.Point(0, 97);
            this.CandidatesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CandidatesList.MinimumSize = new System.Drawing.Size(901, 707);
            this.CandidatesList.Name = "CandidatesList";
            this.CandidatesList.ReadOnly = true;
            this.CandidatesList.RowHeadersVisible = false;
            this.CandidatesList.RowHeadersWidth = 51;
            this.CandidatesList.RowTemplate.Height = 25;
            this.CandidatesList.Size = new System.Drawing.Size(901, 774);
            this.CandidatesList.TabIndex = 6;
            this.CandidatesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CandidatesList_CellContentClick);
            // 
            // electionID
            // 
            this.electionID.HeaderText = "ID";
            this.electionID.MinimumWidth = 6;
            this.electionID.Name = "electionID";
            this.electionID.ReadOnly = true;
            this.electionID.Width = 50;
            // 
            // electionName
            // 
            this.electionName.HeaderText = "Nazwa";
            this.electionName.MinimumWidth = 6;
            this.electionName.Name = "electionName";
            this.electionName.ReadOnly = true;
            this.electionName.Width = 600;
            // 
            // chooseElection
            // 
            this.chooseElection.HeaderText = "Wybierz";
            this.chooseElection.MinimumWidth = 6;
            this.chooseElection.Name = "chooseElection";
            this.chooseElection.ReadOnly = true;
            this.chooseElection.Text = "Wybierz";
            this.chooseElection.ToolTipText = "Wybierz";
            this.chooseElection.UseColumnTextForButtonValue = true;
            this.chooseElection.Width = 80;
            // 
            // ElectionsBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.CandidatesList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ElectionsBody";
            this.Size = new System.Drawing.Size(901, 875);
            this.Load += new System.EventHandler(this.ElectionsBody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataGridView CandidatesList;
        private DataGridViewTextBoxColumn electionID;
        private DataGridViewTextBoxColumn electionName;
        private DataGridViewButtonColumn chooseElection;
    }
}
