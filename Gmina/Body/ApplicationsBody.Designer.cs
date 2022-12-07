namespace Gmina.Body
{
    partial class ApplicationsBody
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
            this.ApplicationsList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submission_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Correct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddApplication = new Gmina.ButtonRounded();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wnioski";
            // 
            // ApplicationsList
            // 
            this.ApplicationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Submission_Date,
            this.Status,
            this.Edit,
            this.Correct,
            this.Cancel});
            this.ApplicationsList.Location = new System.Drawing.Point(39, 295);
            this.ApplicationsList.Name = "ApplicationsList";
            this.ApplicationsList.RowTemplate.Height = 25;
            this.ApplicationsList.Size = new System.Drawing.Size(704, 150);
            this.ApplicationsList.TabIndex = 5;
            this.ApplicationsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicationList_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Nazwa";
            this.Name.Name = "Name";
            // 
            // Submission_Date
            // 
            this.Submission_Date.HeaderText = "Data złożenia";
            this.Submission_Date.Name = "Submission_Date";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edytuj";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edytuj";
            this.Edit.ToolTipText = "Edytuj";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 80;
            // 
            // Correct
            // 
            this.Correct.HeaderText = "Popraw";
            this.Correct.Name = "Correct";
            this.Correct.Text = "Popraw";
            this.Correct.UseColumnTextForButtonValue = true;
            this.Correct.Width = 80;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Anuluj";
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "Anuluj";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 80;
            // 
            // AddApplication
            // 
            this.AddApplication.BackColor = System.Drawing.Color.White;
            this.AddApplication.FlatAppearance.BorderSize = 0;
            this.AddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddApplication.ForeColor = System.Drawing.Color.Black;
            this.AddApplication.Location = new System.Drawing.Point(528, 127);
            this.AddApplication.Name = "AddApplication";
            this.AddApplication.Size = new System.Drawing.Size(150, 40);
            this.AddApplication.TabIndex = 6;
            this.AddApplication.Text = "Dodaj";
            this.AddApplication.UseVisualStyleBackColor = false;
            this.AddApplication.Click += new System.EventHandler(this.AddApplication_Click);
            // 
            // ApplicationsBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.AddApplication);
            this.Controls.Add(this.ApplicationsList);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(788, 656);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataGridView ApplicationsList;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Submission_Date;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Correct;
        private DataGridViewButtonColumn Cancel;
        private ButtonRounded AddApplication;
    }
}
