namespace Gmina.Body
{
    partial class Wnioski
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
            this.Edit,
            this.Correct,
            this.Cancel});
            this.ApplicationsList.Location = new System.Drawing.Point(0, 106);
            this.ApplicationsList.MinimumSize = new System.Drawing.Size(788, 530);
            this.ApplicationsList.Name = "ApplicationsList";
            this.ApplicationsList.ReadOnly = true;
            this.ApplicationsList.RowHeadersVisible = false;
            this.ApplicationsList.RowTemplate.Height = 25;
            this.ApplicationsList.Size = new System.Drawing.Size(788, 550);
            this.ApplicationsList.TabIndex = 5;
            this.ApplicationsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicationList_CellContentClick);
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
            this.Name.Width = 250;
            // 
            // Submission_Date
            // 
            this.Submission_Date.HeaderText = "Data złożenia";
            this.Submission_Date.Name = "Submission_Date";
            this.Submission_Date.ReadOnly = true;
            this.Submission_Date.Width = 143;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edytuj";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edytuj";
            this.Edit.ToolTipText = "Edytuj";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 80;
            // 
            // Correct
            // 
            this.Correct.HeaderText = "Popraw";
            this.Correct.Name = "Correct";
            this.Correct.ReadOnly = true;
            this.Correct.Text = "Popraw";
            this.Correct.UseColumnTextForButtonValue = true;
            this.Correct.Width = 80;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Anuluj";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Text = "Anuluj";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 80;
            // 
            // AddApplication
            // 
            this.AddApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.AddApplication.FlatAppearance.BorderSize = 0;
            this.AddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.AddApplication.Location = new System.Drawing.Point(635, 60);
            this.AddApplication.Name = "AddApplication";
            this.AddApplication.Size = new System.Drawing.Size(150, 40);
            this.AddApplication.TabIndex = 6;
            this.AddApplication.Text = "Dodaj";
            this.AddApplication.UseVisualStyleBackColor = false;
            this.AddApplication.Click += new System.EventHandler(this.AddApplication_Click);
            // 
            // Wnioski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.AddApplication);
            this.Controls.Add(this.ApplicationsList);
            this.Controls.Add(this.label1);
    
            this.Size = new System.Drawing.Size(788, 656);
            this.Load += new System.EventHandler(this.Wnioski_Load);
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
