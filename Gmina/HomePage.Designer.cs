namespace Gmina
{
    partial class HomePage
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
            this.taxesBody = new Gmina.TaxesBody();
            this.Menu = new System.Windows.Forms.Button();
            this.TaxesButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taxesBody1
            // 
            this.taxesBody.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.taxesBody.Location = new System.Drawing.Point(427, 154);
            this.taxesBody.Name = "taxesBody";
            this.taxesBody.Size = new System.Drawing.Size(867, 717);
            this.taxesBody.TabIndex = 0;
            this.taxesBody.Load += new System.EventHandler(this.taxesBody_Load);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(100, 154);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(250, 80);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu Główne";
            this.Menu.UseVisualStyleBackColor = false;
            // 
            // TaxesButton
            // 
            this.TaxesButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TaxesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TaxesButton.ForeColor = System.Drawing.Color.White;
            this.TaxesButton.Location = new System.Drawing.Point(100, 277);
            this.TaxesButton.Name = "TaxesButton";
            this.TaxesButton.Size = new System.Drawing.Size(250, 80);
            this.TaxesButton.TabIndex = 2;
            this.TaxesButton.Text = "Podatki";
            this.TaxesButton.UseVisualStyleBackColor = false;
            this.TaxesButton.Click += new System.EventHandler(this.TaxesButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(100, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wybory";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(100, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 80);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wnioski";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(100, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 80);
            this.button4.TabIndex = 5;
            this.button4.Text = "Wydarzenia";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(100, 724);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 80);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kontakt z supportem";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 1006);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TaxesButton);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.taxesBody);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private TaxesBody taxesBody;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button TaxesButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}