using Gmina.Body;
using GminaApi.Entity;

namespace Gmina
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private void initSingleEvent()
        {
            // 
            // singleEvent1
            // 
            this.singleEvent1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.singleEvent1.ForeColor = System.Drawing.Color.Black;
            this.singleEvent1.Location = new System.Drawing.Point(426, 180);
            this.singleEvent1.Name = "singleEvent1";
            this.singleEvent1.Size = new System.Drawing.Size(901, 876);
            this.singleEvent1.TabIndex = 16;
            this.singleEvent1.Load += new System.EventHandler(this.singleEvent1_Load);
            
        }
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuButton = new Gmina.ButtonRounded();
            this.EvenetButton = new Gmina.ButtonRounded();
            this.ApplicationsButton = new Gmina.ButtonRounded();
            this.ElectionsButton = new Gmina.ButtonRounded();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.logOut = new Gmina.ButtonRounded();
            this.profile2 = new Gmina.ButtonRounded();
            this.reservation2 = new Gmina.ButtonRounded();
            this.supportContactBody1 = new Gmina.Body.SupportContactBody();
            this.applicationSelection1 = new Gmina.Body.ApplicationSelection();
            this.electionsBody1 = new Gmina.Body.ElectionsBody();
            this.aboutCity1 = new Gmina.Body.AboutCity();
            this.menuBody = new Gmina.Body.MenuBody();
            this.taxesBody = new Gmina.Body.TaxesBody();
            this.singleEvent2 = new Gmina.Body.SingleEvent();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coalApplication1 = new Gmina.Body.CoalApplication();
            this.plus500Application1 = new Gmina.Body.Plus500Application();
            this.profileBody1 = new Gmina.Body.ProfileBody();
            this.applicationSelection2 = new Gmina.Body.ApplicationSelection();
            this.wnioski2 = new Gmina.Body.Wnioski();
            this.eventsBody3 = new Gmina.Body.EventsBody(this);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.EvenetButton);
            this.panel1.Controls.Add(this.ApplicationsButton);
            this.panel1.Controls.Add(this.ElectionsButton);
            this.panel1.Location = new System.Drawing.Point(80, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 876);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.MenuButton.Location = new System.Drawing.Point(21, 57);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(250, 100);
            this.MenuButton.TabIndex = 15;
            this.MenuButton.Text = "Informacje o gminie";
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
            this.EvenetButton.Location = new System.Drawing.Point(21, 516);
            this.EvenetButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EvenetButton.Name = "EvenetButton";
            this.EvenetButton.Size = new System.Drawing.Size(250, 100);
            this.EvenetButton.TabIndex = 19;
            this.EvenetButton.Text = "Wydarzenia";
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
            this.ApplicationsButton.Location = new System.Drawing.Point(21, 357);
            this.ApplicationsButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ApplicationsButton.Name = "ApplicationsButton";
            this.ApplicationsButton.Size = new System.Drawing.Size(250, 100);
            this.ApplicationsButton.TabIndex = 18;
            this.ApplicationsButton.Text = "Wnioski";
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
            this.ElectionsButton.Location = new System.Drawing.Point(21, 207);
            this.ElectionsButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ElectionsButton.Name = "ElectionsButton";
            this.ElectionsButton.Size = new System.Drawing.Size(250, 100);
            this.ElectionsButton.TabIndex = 17;
            this.ElectionsButton.Text = "Głosowania";
            this.ElectionsButton.UseVisualStyleBackColor = false;
            this.ElectionsButton.Click += new System.EventHandler(this.ElectionsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.appName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(80, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 137);
            this.panel2.TabIndex = 9;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.appName.Location = new System.Drawing.Point(120, 8);
            this.appName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(142, 96);
            this.appName.TabIndex = 1;
            this.appName.Text = "Urząd \r\nGminy";
            this.appName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gmina.Properties.Resources.office;
            this.pictureBox1.Location = new System.Drawing.Point(21, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.logOut);
            this.panel3.Controls.Add(this.profile2);
            this.panel3.Controls.Add(this.reservation2);
            this.panel3.Location = new System.Drawing.Point(426, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 87);
            this.panel3.TabIndex = 14;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.logOut.Location = new System.Drawing.Point(790, 23);
            this.logOut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(101, 36);
            this.logOut.TabIndex = 26;
            this.logOut.Text = "Wyloguj";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // profile2
            // 
            this.profile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.profile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile2.FlatAppearance.BorderSize = 0;
            this.profile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.profile2.Location = new System.Drawing.Point(670, 23);
            this.profile2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.profile2.Name = "profile2";
            this.profile2.Size = new System.Drawing.Size(101, 36);
            this.profile2.TabIndex = 23;
            this.profile2.Text = "Profil";
            this.profile2.UseVisualStyleBackColor = false;
            this.profile2.Click += new System.EventHandler(this.profileButtonAction);
            // 
            // reservation2
            // 
            this.reservation2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.reservation2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservation2.FlatAppearance.BorderSize = 0;
            this.reservation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reservation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.reservation2.Location = new System.Drawing.Point(30, 23);
            this.reservation2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.reservation2.Name = "reservation2";
            this.reservation2.Size = new System.Drawing.Size(251, 36);
            this.reservation2.TabIndex = 21;
            this.reservation2.Text = "Rezerwacja wizyty w urzędzie";
            this.reservation2.UseVisualStyleBackColor = false;
            this.reservation2.Click += new System.EventHandler(this.reservationButtonAction);
            // 
            // supportContactBody1
            // 
            this.supportContactBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.supportContactBody1.Location = new System.Drawing.Point(426, 180);
            this.supportContactBody1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.supportContactBody1.Name = "supportContactBody1";
            this.supportContactBody1.Size = new System.Drawing.Size(901, 876);
            this.supportContactBody1.TabIndex = 13;
            this.supportContactBody1.Load += new System.EventHandler(this.supportContactBody1_Load);
            // 
            // applicationSelection1
            // 
            this.applicationSelection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.applicationSelection1.Location = new System.Drawing.Point(424, 180);
            this.applicationSelection1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.applicationSelection1.Name = "applicationSelection1";
            this.applicationSelection1.Size = new System.Drawing.Size(901, 875);
            this.applicationSelection1.TabIndex = 19;
            // 
            // electionsBody1
            // 
            this.electionsBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.electionsBody1.Location = new System.Drawing.Point(426, 180);
            this.electionsBody1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.electionsBody1.Name = "electionsBody1";
            this.electionsBody1.Size = new System.Drawing.Size(901, 876);
            this.electionsBody1.TabIndex = 10;
            this.electionsBody1.Load += new System.EventHandler(this.electionsBody_Load);
            // 
            // aboutCity1
            // 
            this.aboutCity1.Location = new System.Drawing.Point(426, 181);
            this.aboutCity1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.aboutCity1.Name = "aboutCity1";
            this.aboutCity1.Size = new System.Drawing.Size(899, 875);
            this.aboutCity1.TabIndex = 15;
            // 
            // menuBody
            // 
            this.menuBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.menuBody.Location = new System.Drawing.Point(426, 180);
            this.menuBody.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.menuBody.Name = "menuBody";
            this.menuBody.Size = new System.Drawing.Size(901, 876);
            this.menuBody.TabIndex = 7;
            this.menuBody.Load += new System.EventHandler(this.menuBody_Load);
            // 
            // taxesBody
            // 
            this.taxesBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.taxesBody.Location = new System.Drawing.Point(426, 180);
            this.taxesBody.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.taxesBody.Name = "taxesBody";
            this.taxesBody.Size = new System.Drawing.Size(901, 876);
            this.taxesBody.TabIndex = 0;
            this.taxesBody.Load += new System.EventHandler(this.taxesBody_Load);
            // 
            // singleEvent2
            // 
            this.singleEvent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.singleEvent2.Description = null;
            this.singleEvent2.ForeColor = System.Drawing.Color.Black;
            this.singleEvent2.Location = new System.Drawing.Point(426, 180);
            this.singleEvent2.Name = "singleEvent2";
            this.singleEvent2.Picture = null;
            this.singleEvent2.Size = new System.Drawing.Size(901, 876);
            this.singleEvent2.TabIndex = 17;
            this.singleEvent2.Title = null;
            this.singleEvent2.Load += new System.EventHandler(this.singleEvent2_Load);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(80, 1076);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1247, 57);
            this.panel4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(971, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projekt i wykonanie: GGGJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urząd Gminy";
            // 
            // coalApplication1
            // 
            this.coalApplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.coalApplication1.Location = new System.Drawing.Point(426, 181);
            this.coalApplication1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.coalApplication1.Name = "coalApplication1";
            this.coalApplication1.Size = new System.Drawing.Size(901, 875);
            this.coalApplication1.TabIndex = 20;
            // 
            // plus500Application1
            // 
            this.plus500Application1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.plus500Application1.Location = new System.Drawing.Point(426, 180);
            this.plus500Application1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.plus500Application1.Name = "plus500Application1";
            this.plus500Application1.Size = new System.Drawing.Size(901, 875);
            this.plus500Application1.TabIndex = 21;
            // 
            // profileBody1
            // 
            this.profileBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.profileBody1.Location = new System.Drawing.Point(424, 181);
            this.profileBody1.Name = "profileBody1";
            this.profileBody1.Size = new System.Drawing.Size(903, 875);
            this.profileBody1.TabIndex = 22;
            this.profileBody1.Load += new System.EventHandler(this.profileBody1_Load);
            // 
            // applicationSelection2
            // 
            this.applicationSelection2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.applicationSelection2.Location = new System.Drawing.Point(426, 180);
            this.applicationSelection2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applicationSelection2.Name = "applicationSelection2";
            this.applicationSelection2.Size = new System.Drawing.Size(901, 868);
            this.applicationSelection2.TabIndex = 23;
            // 
            // wnioski2
            // 
            this.wnioski2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.wnioski2.Location = new System.Drawing.Point(426, 181);
            this.wnioski2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wnioski2.Name = "wnioski2";
            this.wnioski2.Size = new System.Drawing.Size(901, 867);
            this.wnioski2.TabIndex = 24;
            // 
            // eventsBody3
            // 
            this.eventsBody3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.eventsBody3.Location = new System.Drawing.Point(426, 181);
            this.eventsBody3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventsBody3.Name = "eventsBody3";
            this.eventsBody3.Size = new System.Drawing.Size(901, 867);
            this.eventsBody3.TabIndex = 25;
            this.eventsBody3.Load += new System.EventHandler(this.eventsBody3_Load);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1384, 1151);
            this.Controls.Add(this.eventsBody3);
            this.Controls.Add(this.wnioski2);
            this.Controls.Add(this.applicationSelection2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aboutCity1);
            this.Controls.Add(this.electionsBody1);
            this.Controls.Add(this.menuBody);
            this.Controls.Add(this.taxesBody);
            this.Controls.Add(this.supportContactBody1);
            this.Controls.Add(this.profileBody1);
            this.Controls.Add(this.plus500Application1);
            this.Controls.Add(this.coalApplication1);
            this.Controls.Add(this.applicationSelection1);
            this.Controls.Add(this.singleEvent2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
      

        private TaxesBody taxesBody;
        private MenuBody menuBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Body.ElectionsBody electionsBody1;
        private Body.Wnioski applicationsBody1;
        private Body.SupportContactBody supportContactBody1;
        private Body.AboutCity aboutCity1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Panel panel3;
        private ButtonRounded MenuButton;
        private ButtonRounded ElectionsButton;
        private ButtonRounded ApplicationsButton;
        private ButtonRounded EvenetButton;
        private ButtonRounded reservation2;
        private ButtonRounded profile2;
        private Body.SingleEvent singleEvent1;
        private EventsBody eventsBody1;
        private SingleEvent singleEvent2;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private ApplicationSelection applicationSelection1;
        private CoalApplication coalApplication1;
        private Plus500Application plus500Application1;
        private ProfileBody profileBody1;
        private static UserEntity currentUser;
        private ButtonRounded logOut;
        private Wnioski wnioski1;
        private ApplicationSelection applicationSelection2;
        private Wnioski wnioski2;
        private EventsBody eventsBody2;
        private EventsBody eventsBody3;
    }
}