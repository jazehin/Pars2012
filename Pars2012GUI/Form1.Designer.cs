namespace Pars2012GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbNevek = new ComboBox();
            lblCsoport = new Label();
            lblNemzet = new Label();
            lblKod = new Label();
            lblSorozat = new Label();
            lblEredmeny = new Label();
            label7 = new Label();
            pbZaszlo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbZaszlo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 32);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Válasszon versenyzőt!";
            // 
            // cbNevek
            // 
            cbNevek.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNevek.FormattingEnabled = true;
            cbNevek.Location = new Point(86, 61);
            cbNevek.Name = "cbNevek";
            cbNevek.Size = new Size(192, 23);
            cbNevek.TabIndex = 1;
            cbNevek.SelectedIndexChanged += cbNevek_SelectedIndexChanged;
            // 
            // lblCsoport
            // 
            lblCsoport.AutoSize = true;
            lblCsoport.Location = new Point(74, 109);
            lblCsoport.Name = "lblCsoport";
            lblCsoport.Size = new Size(52, 15);
            lblCsoport.TabIndex = 2;
            lblCsoport.Text = "Csoport:";
            // 
            // lblNemzet
            // 
            lblNemzet.AutoSize = true;
            lblNemzet.Location = new Point(74, 141);
            lblNemzet.Name = "lblNemzet";
            lblNemzet.Size = new Size(51, 15);
            lblNemzet.TabIndex = 3;
            lblNemzet.Text = "Nemzet:";
            // 
            // lblKod
            // 
            lblKod.AutoSize = true;
            lblKod.Location = new Point(74, 171);
            lblKod.Name = "lblKod";
            lblKod.Size = new Size(74, 15);
            lblKod.TabIndex = 4;
            lblKod.Text = "Nemzet kód:";
            // 
            // lblSorozat
            // 
            lblSorozat.AutoSize = true;
            lblSorozat.Location = new Point(74, 201);
            lblSorozat.Name = "lblSorozat";
            lblSorozat.Size = new Size(49, 15);
            lblSorozat.TabIndex = 5;
            lblSorozat.Text = "Sorozat:";
            // 
            // lblEredmeny
            // 
            lblEredmeny.AutoSize = true;
            lblEredmeny.Location = new Point(74, 233);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(63, 15);
            lblEredmeny.TabIndex = 6;
            lblEredmeny.Text = "Eredmény:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 263);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 7;
            label7.Text = "Zászló:";
            // 
            // pbZaszlo
            // 
            pbZaszlo.Location = new Point(86, 281);
            pbZaszlo.Name = "pbZaszlo";
            pbZaszlo.Size = new Size(227, 127);
            pbZaszlo.SizeMode = PictureBoxSizeMode.Zoom;
            pbZaszlo.TabIndex = 8;
            pbZaszlo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(pbZaszlo);
            Controls.Add(label7);
            Controls.Add(lblEredmeny);
            Controls.Add(lblSorozat);
            Controls.Add(lblKod);
            Controls.Add(lblNemzet);
            Controls.Add(lblCsoport);
            Controls.Add(cbNevek);
            Controls.Add(label1);
            Name = "Form1";
            Text = "London 2012 - Férfi kalapácsvetés - selejtező";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbZaszlo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbNevek;
        private Label lblCsoport;
        private Label lblNemzet;
        private Label lblKod;
        private Label lblSorozat;
        private Label lblEredmeny;
        private Label label7;
        private PictureBox pbZaszlo;
    }
}