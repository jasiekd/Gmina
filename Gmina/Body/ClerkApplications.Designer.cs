namespace Gmina.Body
{
    partial class ClerkApplications
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
            this.ApplicationsList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submission_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppDecision = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationsList
            // 
            this.ApplicationsList.AllowUserToAddRows = false;
            this.ApplicationsList.AllowUserToDeleteRows = false;
            this.ApplicationsList.AllowUserToResizeRows = false;
            this.ApplicationsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.ApplicationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Submission_Date,
            this.Status,
            this.AppDecision});
            this.ApplicationsList.Location = new System.Drawing.Point(0, 111);
            this.ApplicationsList.MinimumSize = new System.Drawing.Size(788, 530);
            this.ApplicationsList.Name = "ApplicationsList";
            this.ApplicationsList.ReadOnly = true;
            this.ApplicationsList.RowHeadersVisible = false;
            this.ApplicationsList.RowTemplate.Height = 25;
            this.ApplicationsList.Size = new System.Drawing.Size(788, 550);
            this.ApplicationsList.TabIndex = 6;
            this.ApplicationsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicationsList_CellClick);
            this.ApplicationsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicationsList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wnioski do rozpatrzenia";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nazwa";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 340;
            // 
            // Submission_Date
            // 
            this.Submission_Date.HeaderText = "Data złożenia";
            this.Submission_Date.Name = "Submission_Date";
            this.Submission_Date.ReadOnly = true;
            this.Submission_Date.Width = 160;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 170;
            // 
            // AppDecision
            // 
            this.AppDecision.HeaderText = "Rozpatrz";
            this.AppDecision.Name = "AppDecision";
            this.AppDecision.ReadOnly = true;
            this.AppDecision.Text = "Rozpatrz";
            this.AppDecision.UseColumnTextForButtonValue = true;
            this.AppDecision.Width = 63;
            // 
            // ClerkApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplicationsList);
           // this.Name = "ClerkApplications";
            this.Size = new System.Drawing.Size(788, 661);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ApplicationsList;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Correct;
        private DataGridViewButtonColumn Cancel;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Submission_Date;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn AppDecision;
    }
}
