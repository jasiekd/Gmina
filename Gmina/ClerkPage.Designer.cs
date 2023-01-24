using GminaApi.Entity;

namespace Gmina
{
    partial class ClerkPage
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

        static public void setUser(UserEntity user)
        {
            currentUser = user;
        }
        static public UserEntity getUser()
        {
            return currentUser;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuButton = new Gmina.ButtonRounded();
            this.EvenetButton = new Gmina.ButtonRounded();
            this.ApplicationsButton = new Gmina.ButtonRounded();
            this.ElectionsButton = new Gmina.ButtonRounded();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profile2 = new Gmina.ButtonRounded();
            this.AddUserButton = new Gmina.ButtonRounded();
            this.logOut = new Gmina.ButtonRounded();
            this.settings2 = new Gmina.ButtonRounded();
            this.clerkAddEvent1 = new Gmina.Body.ClerkAddEvent();
            this.addUserBody1 = new Gmina.Body.AddUserBody();
            this.menuBody1 = new Gmina.Body.MenuBody();
            this.profileBody1 = new Gmina.Body.ProfileBody();
            this.electionOrganization1 = new Gmina.Body.ElectionOrganization();
            this.clerkApplications6 = new Gmina.Body.ClerkApplications();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.appName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(70, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 103);
            this.panel2.TabIndex = 16;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.appName.Location = new System.Drawing.Point(105, 6);
            this.appName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(117, 78);
            this.appName.TabIndex = 1;
            this.appName.Text = "Urząd \r\nGminy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gmina.Properties.Resources.office;
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.EvenetButton);
            this.panel1.Controls.Add(this.ApplicationsButton);
            this.panel1.Controls.Add(this.ElectionsButton);
            this.panel1.Location = new System.Drawing.Point(70, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 657);
            this.panel1.TabIndex = 17;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.MenuButton.Location = new System.Drawing.Point(18, 28);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(219, 75);
            this.MenuButton.TabIndex = 15;
            this.MenuButton.Text = "Menu Główne";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // EvenetButton
            // 
            this.EvenetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.EvenetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EvenetButton.FlatAppearance.BorderSize = 0;
            this.EvenetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EvenetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EvenetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.EvenetButton.Location = new System.Drawing.Point(18, 338);
            this.EvenetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EvenetButton.Name = "EvenetButton";
            this.EvenetButton.Size = new System.Drawing.Size(219, 75);
            this.EvenetButton.TabIndex = 19;
            this.EvenetButton.Text = "Dodawanie wydarzeń";
            this.EvenetButton.UseVisualStyleBackColor = false;
            this.EvenetButton.Click += new System.EventHandler(this.EvenetButton_Click);
            // 
            // ApplicationsButton
            // 
            this.ApplicationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.ApplicationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplicationsButton.FlatAppearance.BorderSize = 0;
            this.ApplicationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApplicationsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ApplicationsButton.Location = new System.Drawing.Point(18, 236);
            this.ApplicationsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplicationsButton.Name = "ApplicationsButton";
            this.ApplicationsButton.Size = new System.Drawing.Size(219, 75);
            this.ApplicationsButton.TabIndex = 18;
            this.ApplicationsButton.Text = "Rozpatrywanie Wniosków";
            this.ApplicationsButton.UseVisualStyleBackColor = false;
            this.ApplicationsButton.Click += new System.EventHandler(this.ApplicationsButton_Click);
            // 
            // ElectionsButton
            // 
            this.ElectionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.ElectionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ElectionsButton.FlatAppearance.BorderSize = 0;
            this.ElectionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElectionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ElectionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ElectionsButton.Location = new System.Drawing.Point(18, 134);
            this.ElectionsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ElectionsButton.Name = "ElectionsButton";
            this.ElectionsButton.Size = new System.Drawing.Size(219, 75);
            this.ElectionsButton.TabIndex = 17;
            this.ElectionsButton.Text = "Organizacja Głosowań";
            this.ElectionsButton.UseVisualStyleBackColor = false;
            this.ElectionsButton.Click += new System.EventHandler(this.ElectionsButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(70, 807);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1091, 43);
            this.panel4.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(850, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projekt i wykonanie: GGGJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urząd Gminy";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.profile2);
            this.panel3.Controls.Add(this.AddUserButton);
            this.panel3.Controls.Add(this.logOut);
            this.panel3.Controls.Add(this.settings2);
            this.panel3.Location = new System.Drawing.Point(373, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 65);
            this.panel3.TabIndex = 20;
            // 
            // profile2
            // 
            this.profile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.profile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile2.FlatAppearance.BorderSize = 0;
            this.profile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.profile2.Location = new System.Drawing.Point(469, 17);
            this.profile2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profile2.Name = "profile2";
            this.profile2.Size = new System.Drawing.Size(88, 27);
            this.profile2.TabIndex = 27;
            this.profile2.Text = "Profil";
            this.profile2.UseVisualStyleBackColor = false;
            this.profile2.Click += new System.EventHandler(this.profile2_Click_1);
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.AddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserButton.FlatAppearance.BorderSize = 0;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.AddUserButton.Location = new System.Drawing.Point(32, 19);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(147, 27);
            this.AddUserButton.TabIndex = 26;
            this.AddUserButton.Text = "Dodaj użytkownika";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.logOut.Location = new System.Drawing.Point(682, 19);
            this.logOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(88, 27);
            this.logOut.TabIndex = 25;
            this.logOut.Text = "Wyloguj";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // settings2
            // 
            this.settings2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.settings2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings2.FlatAppearance.BorderSize = 0;
            this.settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settings2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.settings2.Location = new System.Drawing.Point(585, 19);
            this.settings2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settings2.Name = "settings2";
            this.settings2.Size = new System.Drawing.Size(88, 27);
            this.settings2.TabIndex = 24;
            this.settings2.Text = "Ustawienia";
            this.settings2.UseVisualStyleBackColor = false;
            // 
            // clerkAddEvent1
            // 
            this.clerkAddEvent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.clerkAddEvent1.Location = new System.Drawing.Point(373, 135);
            this.clerkAddEvent1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clerkAddEvent1.Name = "clerkAddEvent1";
            this.clerkAddEvent1.Size = new System.Drawing.Size(788, 661);
            this.clerkAddEvent1.TabIndex = 21;
            // 
            // addUserBody1
            // 
            this.addUserBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.addUserBody1.Location = new System.Drawing.Point(373, 135);
            this.addUserBody1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUserBody1.Name = "addUserBody1";
            this.addUserBody1.Size = new System.Drawing.Size(788, 661);
            this.addUserBody1.TabIndex = 22;
            this.addUserBody1.Load += new System.EventHandler(this.addUserBody1_Load);
            // 
            // menuBody1
            // 
            this.menuBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.menuBody1.Location = new System.Drawing.Point(373, 135);
            this.menuBody1.Name = "menuBody1";
            this.menuBody1.Size = new System.Drawing.Size(784, 657);
            this.menuBody1.TabIndex = 24;
            this.menuBody1.Load += new System.EventHandler(this.menuBody1_Load);
            // 
            // profileBody1
            // 
            this.profileBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.profileBody1.Location = new System.Drawing.Point(373, 135);
            this.profileBody1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileBody1.Name = "profileBody1";
            this.profileBody1.Size = new System.Drawing.Size(788, 661);
            this.profileBody1.TabIndex = 25;
            this.profileBody1.Load += new System.EventHandler(this.profileBody1_Load);
            // 
            // electionOrganization1
            // 
            this.electionOrganization1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.electionOrganization1.Location = new System.Drawing.Point(373, 136);
            this.electionOrganization1.Name = "electionOrganization1";
            this.electionOrganization1.Size = new System.Drawing.Size(788, 656);
            this.electionOrganization1.TabIndex = 26;
            this.electionOrganization1.Load += new System.EventHandler(this.electionOrganization1_Load);
            // 
            // clerkApplications6
            // 
            this.clerkApplications6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.clerkApplications6.Location = new System.Drawing.Point(373, 136);
            this.clerkApplications6.Name = "clerkApplications6";
            this.clerkApplications6.Size = new System.Drawing.Size(788, 661);
            this.clerkApplications6.TabIndex = 27;
            // 
            // ClerkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1211, 796);
            this.Controls.Add(this.clerkApplications6);
            this.Controls.Add(this.profileBody1);
            this.Controls.Add(this.menuBody1);
            this.Controls.Add(this.addUserBody1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clerkAddEvent1);
            this.Controls.Add(this.electionOrganization1);
            this.Name = "ClerkPage";
            this.Text = "ClerkPage";
            this.Load += new System.EventHandler(this.ClerkPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label appName;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ButtonRounded SupportContactButton;
        private ButtonRounded MenuButton;
        private ButtonRounded EvenetButton;
        private ButtonRounded TaxesButton;
        private ButtonRounded ApplicationsButton;
        private ButtonRounded ElectionsButton;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private ButtonRounded settings2;
        private Body.ClerkApplications clerkApplications1;
        static private UserEntity currentUser;
        private ButtonRounded logOut;
        private Body.ClerkApplications clerkApplications2;
        private Body.ClerkAddEvent clerkAddEvent1;
        private Body.ClerkApplications clerkApplications3;
        private Body.ClerkApplications clerkApplications4;
        private Body.AddUserBody addUserBody1;
        private ButtonRounded AddUserButton;
        private Body.ClerkApplications clerkApplications5;
        private Body.MenuBody menuBody1;
        private Body.ProfileBody profileBody1;
        private ButtonRounded profile2;
        private Body.ElectionOrganization electionOrganization1;
        private Body.ClerkApplications clerkApplications6;
    }
}