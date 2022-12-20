using Gmina.Body;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SupportContactButton = new Gmina.ButtonRounded();
            this.MenuButton = new Gmina.ButtonRounded();
            this.EvenetButton = new Gmina.ButtonRounded();
            this.TaxesButton = new Gmina.ButtonRounded();
            this.ApplicationsButton = new Gmina.ButtonRounded();
            this.ElectionsButton = new Gmina.ButtonRounded();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.profile2 = new Gmina.ButtonRounded();
            this.settings2 = new Gmina.ButtonRounded();
            this.aboutCity2 = new Gmina.ButtonRounded();
            this.reservation2 = new Gmina.ButtonRounded();
            this.supportContactBody1 = new Gmina.Body.SupportContactBody();
            this.applicationsBody1 = new Gmina.Body.Wnioski();
            this.applicationSelection1 = new Gmina.Body.ApplicationSelection();
            this.electionsBody1 = new Gmina.Body.ElectionsBody();
            this.menuBody = new Gmina.Body.MenuBody();
            this.taxesBody = new Gmina.Body.TaxesBody();
            this.eventsBody1 = new Gmina.Body.EventsBody();
            this.singleEvent2 = new Gmina.Body.SingleEvent();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coalApplication1 = new Gmina.Body.CoalApplication();
            this.plus500Application1 = new Gmina.Body.Plus500Application();
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
            this.panel1.Controls.Add(this.SupportContactButton);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.EvenetButton);
            this.panel1.Controls.Add(this.TaxesButton);
            this.panel1.Controls.Add(this.ApplicationsButton);
            this.panel1.Controls.Add(this.ElectionsButton);
            this.panel1.Location = new System.Drawing.Point(70, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 657);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SupportContactButton
            // 
            this.SupportContactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.SupportContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupportContactButton.FlatAppearance.BorderSize = 0;
            this.SupportContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupportContactButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.SupportContactButton.Location = new System.Drawing.Point(18, 545);
            this.SupportContactButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SupportContactButton.Name = "SupportContactButton";
            this.SupportContactButton.Size = new System.Drawing.Size(219, 75);
            this.SupportContactButton.TabIndex = 20;
            this.SupportContactButton.Text = "Kontakt z supportem";
            this.SupportContactButton.UseVisualStyleBackColor = false;
            this.SupportContactButton.Click += new System.EventHandler(this.SupportContactButton_Click);
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
            this.EvenetButton.Location = new System.Drawing.Point(18, 442);
            this.EvenetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EvenetButton.Name = "EvenetButton";
            this.EvenetButton.Size = new System.Drawing.Size(219, 75);
            this.EvenetButton.TabIndex = 19;
            this.EvenetButton.Text = "Wydarzenia";
            this.EvenetButton.UseVisualStyleBackColor = false;
            this.EvenetButton.Click += new System.EventHandler(this.EvenetButton_Click);
            // 
            // TaxesButton
            // 
            this.TaxesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.TaxesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaxesButton.FlatAppearance.BorderSize = 0;
            this.TaxesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaxesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.TaxesButton.Location = new System.Drawing.Point(18, 127);
            this.TaxesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TaxesButton.Name = "TaxesButton";
            this.TaxesButton.Size = new System.Drawing.Size(219, 75);
            this.TaxesButton.TabIndex = 16;
            this.TaxesButton.Text = "Podatki";
            this.TaxesButton.UseVisualStyleBackColor = false;
            this.TaxesButton.Click += new System.EventHandler(this.TaxesButton_Click);
            // 
            // ApplicationsButton
            // 
            this.ApplicationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.ApplicationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplicationsButton.FlatAppearance.BorderSize = 0;
            this.ApplicationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApplicationsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ApplicationsButton.Location = new System.Drawing.Point(18, 333);
            this.ApplicationsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplicationsButton.Name = "ApplicationsButton";
            this.ApplicationsButton.Size = new System.Drawing.Size(219, 75);
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
            this.ElectionsButton.Location = new System.Drawing.Point(18, 233);
            this.ElectionsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ElectionsButton.Name = "ElectionsButton";
            this.ElectionsButton.Size = new System.Drawing.Size(219, 75);
            this.ElectionsButton.TabIndex = 17;
            this.ElectionsButton.Text = "Wybory";
            this.ElectionsButton.UseVisualStyleBackColor = false;
            this.ElectionsButton.Click += new System.EventHandler(this.ElectionsButton_Click);
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
            this.panel2.TabIndex = 9;
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
            this.appName.Click += new System.EventHandler(this.label1_Click);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.profile2);
            this.panel3.Controls.Add(this.settings2);
            this.panel3.Controls.Add(this.aboutCity2);
            this.panel3.Controls.Add(this.reservation2);
            this.panel3.Location = new System.Drawing.Point(373, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 65);
            this.panel3.TabIndex = 14;
            // 
            // profile2
            // 
            this.profile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.profile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile2.FlatAppearance.BorderSize = 0;
            this.profile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.profile2.Location = new System.Drawing.Point(588, 17);
            this.profile2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profile2.Name = "profile2";
            this.profile2.Size = new System.Drawing.Size(88, 27);
            this.profile2.TabIndex = 23;
            this.profile2.Text = "Profil";
            this.profile2.UseVisualStyleBackColor = false;
            this.profile2.Click += new System.EventHandler(this.profileButtonAction);
            // 
            // settings2
            // 
            this.settings2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.settings2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings2.FlatAppearance.BorderSize = 0;
            this.settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settings2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.settings2.Location = new System.Drawing.Point(682, 17);
            this.settings2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settings2.Name = "settings2";
            this.settings2.Size = new System.Drawing.Size(88, 27);
            this.settings2.TabIndex = 24;
            this.settings2.Text = "Ustawienia";
            this.settings2.UseVisualStyleBackColor = false;
            this.settings2.Click += new System.EventHandler(this.settingsButtonAction);
            // 
            // aboutCity2
            // 
            this.aboutCity2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.aboutCity2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutCity2.FlatAppearance.BorderSize = 0;
            this.aboutCity2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutCity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutCity2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.aboutCity2.Location = new System.Drawing.Point(270, 17);
            this.aboutCity2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aboutCity2.Name = "aboutCity2";
            this.aboutCity2.Size = new System.Drawing.Size(88, 27);
            this.aboutCity2.TabIndex = 22;
            this.aboutCity2.Text = "O mieście";
            this.aboutCity2.UseVisualStyleBackColor = false;
            this.aboutCity2.Click += new System.EventHandler(this.aboutButtonAction);
            // 
            // reservation2
            // 
            this.reservation2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.reservation2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservation2.FlatAppearance.BorderSize = 0;
            this.reservation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reservation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.reservation2.Location = new System.Drawing.Point(26, 17);
            this.reservation2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reservation2.Name = "reservation2";
            this.reservation2.Size = new System.Drawing.Size(220, 27);
            this.reservation2.TabIndex = 21;
            this.reservation2.Text = "Rezerwacja wizyty w urzędzie";
            this.reservation2.UseVisualStyleBackColor = false;
            this.reservation2.Click += new System.EventHandler(this.reservationButtonAction);
            // 
            // supportContactBody1
            // 
            this.supportContactBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.supportContactBody1.Location = new System.Drawing.Point(373, 135);
            this.supportContactBody1.Margin = new System.Windows.Forms.Padding(2);
            this.supportContactBody1.Name = "supportContactBody1";
            this.supportContactBody1.Size = new System.Drawing.Size(788, 657);
            this.supportContactBody1.TabIndex = 13;
            this.supportContactBody1.Load += new System.EventHandler(this.supportContactBody1_Load);
            // 
            // applicationsBody1
            // 
            this.applicationsBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.applicationsBody1.Location = new System.Drawing.Point(373, 135);
            this.applicationsBody1.Margin = new System.Windows.Forms.Padding(2);
            this.applicationsBody1.Name = "applicationsBody1";
            this.applicationsBody1.Size = new System.Drawing.Size(788, 657);
            this.applicationsBody1.TabIndex = 11;
            this.applicationsBody1.Load += new System.EventHandler(this.applicationsBody1_Load);
            // 
            // applicationSelection1
            // 
            this.applicationSelection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.applicationSelection1.Location = new System.Drawing.Point(371, 135);
            this.applicationSelection1.Name = "applicationSelection1";
            this.applicationSelection1.Size = new System.Drawing.Size(788, 656);
            this.applicationSelection1.TabIndex = 19;
            // 
            // electionsBody1
            // 
            this.electionsBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.electionsBody1.Location = new System.Drawing.Point(373, 135);
            this.electionsBody1.Margin = new System.Windows.Forms.Padding(2);
            this.electionsBody1.Name = "electionsBody1";
            this.electionsBody1.Size = new System.Drawing.Size(788, 657);
            this.electionsBody1.TabIndex = 10;
            this.electionsBody1.Load += new System.EventHandler(this.electionsBody_Load);
            // 
            // menuBody
            // 
            this.menuBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.menuBody.Location = new System.Drawing.Point(373, 135);
            this.menuBody.Margin = new System.Windows.Forms.Padding(2);
            this.menuBody.Name = "menuBody";
            this.menuBody.Size = new System.Drawing.Size(788, 657);
            this.menuBody.TabIndex = 7;
            this.menuBody.Load += new System.EventHandler(this.menuBody_Load);
            // 
            // taxesBody
            // 
            this.taxesBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.taxesBody.Location = new System.Drawing.Point(373, 135);
            this.taxesBody.Margin = new System.Windows.Forms.Padding(2);
            this.taxesBody.Name = "taxesBody";
            this.taxesBody.Size = new System.Drawing.Size(788, 657);
            this.taxesBody.TabIndex = 0;
            this.taxesBody.Load += new System.EventHandler(this.taxesBody_Load);
            // 
            // eventsBody1
            // 
            this.eventsBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.eventsBody1.Location = new System.Drawing.Point(373, 135);
            this.eventsBody1.Name = "eventsBody1";
            this.eventsBody1.Size = new System.Drawing.Size(788, 657);
            this.eventsBody1.TabIndex = 16;
            this.eventsBody1.Load += new System.EventHandler(this.eventsBody1_Load_1);
            // 
            // singleEvent2
            // 
            this.singleEvent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            this.singleEvent2.Description = null;
            this.singleEvent2.ForeColor = System.Drawing.Color.Black;
            this.singleEvent2.Location = new System.Drawing.Point(373, 135);
            this.singleEvent2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singleEvent2.Name = "singleEvent2";
            this.singleEvent2.Picture = null;
            this.singleEvent2.Size = new System.Drawing.Size(788, 657);
            this.singleEvent2.TabIndex = 17;
            this.singleEvent2.Title = null;
            this.singleEvent2.Load += new System.EventHandler(this.singleEvent2_Load);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(70, 807);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1091, 43);
            this.panel4.TabIndex = 18;
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
            // coalApplication1
            // 
            this.coalApplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.coalApplication1.Location = new System.Drawing.Point(373, 136);
            this.coalApplication1.Name = "coalApplication1";
            this.coalApplication1.Size = new System.Drawing.Size(788, 656);
            this.coalApplication1.TabIndex = 20;
            // 
            // plus500Application1
            // 
            this.plus500Application1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(128)))));
            this.plus500Application1.Location = new System.Drawing.Point(373, 135);
            this.plus500Application1.Name = "plus500Application1";
            this.plus500Application1.Size = new System.Drawing.Size(788, 656);
            this.plus500Application1.TabIndex = 21;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1211, 863);
            this.Controls.Add(this.plus500Application1);
            this.Controls.Add(this.coalApplication1);
            this.Controls.Add(this.applicationSelection1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.singleEvent2);
            this.Controls.Add(this.eventsBody1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.applicationsBody1);
            this.Controls.Add(this.electionsBody1);
            this.Controls.Add(this.menuBody);
            this.Controls.Add(this.taxesBody);
            this.Controls.Add(this.supportContactBody1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Panel panel3;
        private ButtonRounded MenuButton;
        private ButtonRounded TaxesButton;
        private ButtonRounded ElectionsButton;
        private ButtonRounded ApplicationsButton;
        private ButtonRounded EvenetButton;
        private ButtonRounded SupportContactButton;
        private ButtonRounded reservation2;
        private ButtonRounded aboutCity2;
        private ButtonRounded profile2;
        private ButtonRounded settings2;
        private Body.SingleEvent singleEvent1;
        private EventsBody eventsBody1;
        private SingleEvent singleEvent2;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private ApplicationSelection applicationSelection1;
        private CoalApplication coalApplication1;
        private Plus500Application plus500Application1;
    }
}