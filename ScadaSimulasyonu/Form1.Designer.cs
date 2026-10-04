namespace ScadaSimulasyonu
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
            components = new System.ComponentModel.Container();
            btnSistemKontrol = new Button();
            btnPompa = new Button();
            btnVana = new Button();
            btnIsitici = new Button();
            btnAlarmSifirla = new Button();
            prgTankSeviye = new ProgressBar();
            lblSeviye = new Label();
            lblSicaklik = new Label();
            lblBasinc = new Label();
            lblSistemDurum = new Label();
            pnlPompaDurum = new Panel();
            pnlVanaDurum = new Panel();
            pnlIsiticiDurum = new Panel();
            lstAlarmlar = new ListBox();
            timersimulasyon = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnSistemKontrol
            // 
            btnSistemKontrol.Location = new Point(22, 33);
            btnSistemKontrol.Name = "btnSistemKontrol";
            btnSistemKontrol.Size = new Size(115, 29);
            btnSistemKontrol.TabIndex = 0;
            btnSistemKontrol.Text = "Sistemi Başlat\r\n";
            btnSistemKontrol.UseVisualStyleBackColor = true;
            btnSistemKontrol.Click += button1_Click;
            // 
            // btnPompa
            // 
            btnPompa.Location = new Point(229, 33);
            btnPompa.Name = "btnPompa";
            btnPompa.Size = new Size(141, 29);
            btnPompa.TabIndex = 1;
            btnPompa.Text = "Pompa Aç/Kapat";
            btnPompa.UseVisualStyleBackColor = true;
            btnPompa.Click += btnPompa_Click;
            // 
            // btnVana
            // 
            btnVana.Location = new Point(556, 33);
            btnVana.Name = "btnVana";
            btnVana.Size = new Size(115, 29);
            btnVana.TabIndex = 2;
            btnVana.Text = "Vana Aç/Kapat";
            btnVana.UseVisualStyleBackColor = true;
            btnVana.Click += btnVana_Click;
            // 
            // btnIsitici
            // 
            btnIsitici.Location = new Point(534, 242);
            btnIsitici.Name = "btnIsitici";
            btnIsitici.Size = new Size(115, 29);
            btnIsitici.TabIndex = 3;
            btnIsitici.Text = "Isıtıcı Aç/Kapat";
            btnIsitici.UseVisualStyleBackColor = true;
            btnIsitici.Click += btnIsitici_Click;
            // 
            // btnAlarmSifirla
            // 
            btnAlarmSifirla.Location = new Point(22, 81);
            btnAlarmSifirla.Name = "btnAlarmSifirla";
            btnAlarmSifirla.Size = new Size(115, 29);
            btnAlarmSifirla.TabIndex = 4;
            btnAlarmSifirla.Text = "Alarmı Sıfırla";
            btnAlarmSifirla.UseVisualStyleBackColor = true;
            btnAlarmSifirla.Click += btnAlarmSifirla_Click;
            // 
            // prgTankSeviye
            // 
            prgTankSeviye.Location = new Point(12, 327);
            prgTankSeviye.Name = "prgTankSeviye";
            prgTankSeviye.Size = new Size(199, 38);
            prgTankSeviye.TabIndex = 5;
            prgTankSeviye.Value = 25;
            // 
            // lblSeviye
            // 
            lblSeviye.AutoSize = true;
            lblSeviye.Location = new Point(34, 276);
            lblSeviye.Name = "lblSeviye";
            lblSeviye.Size = new Size(48, 20);
            lblSeviye.TabIndex = 6;
            lblSeviye.Text = "%25.0";
            // 
            // lblSicaklik
            // 
            lblSicaklik.AutoSize = true;
            lblSicaklik.Location = new Point(34, 233);
            lblSicaklik.Name = "lblSicaklik";
            lblSicaklik.Size = new Size(51, 20);
            lblSicaklik.TabIndex = 7;
            lblSicaklik.Text = "22.0°C";
            // 
            // lblBasinc
            // 
            lblBasinc.AutoSize = true;
            lblBasinc.Location = new Point(34, 186);
            lblBasinc.Name = "lblBasinc";
            lblBasinc.Size = new Size(58, 20);
            lblBasinc.TabIndex = 8;
            lblBasinc.Text = "1.00Bar";
            // 
            // lblSistemDurum
            // 
            lblSistemDurum.AutoSize = true;
            lblSistemDurum.Location = new Point(22, 138);
            lblSistemDurum.Name = "lblSistemDurum";
            lblSistemDurum.Size = new Size(107, 20);
            lblSistemDurum.TabIndex = 9;
            lblSistemDurum.Text = "Sistem Normal";
            // 
            // pnlPompaDurum
            // 
            pnlPompaDurum.BackColor = Color.Gray;
            pnlPompaDurum.Location = new Point(229, 81);
            pnlPompaDurum.Name = "pnlPompaDurum";
            pnlPompaDurum.Size = new Size(250, 125);
            pnlPompaDurum.TabIndex = 10;
            // 
            // pnlVanaDurum
            // 
            pnlVanaDurum.BackColor = Color.Gray;
            pnlVanaDurum.Location = new Point(534, 81);
            pnlVanaDurum.Name = "pnlVanaDurum";
            pnlVanaDurum.Size = new Size(250, 125);
            pnlVanaDurum.TabIndex = 11;
            // 
            // pnlIsiticiDurum
            // 
            pnlIsiticiDurum.BackColor = Color.Gray;
            pnlIsiticiDurum.Location = new Point(534, 301);
            pnlIsiticiDurum.Name = "pnlIsiticiDurum";
            pnlIsiticiDurum.Size = new Size(250, 125);
            pnlIsiticiDurum.TabIndex = 12;
            // 
            // lstAlarmlar
            // 
            lstAlarmlar.FormattingEnabled = true;
            lstAlarmlar.Location = new Point(245, 261);
            lstAlarmlar.Name = "lstAlarmlar";
            lstAlarmlar.Size = new Size(234, 104);
            lstAlarmlar.TabIndex = 13;
            // 
            // timersimulasyon
            // 
            timersimulasyon.Interval = 1000;
            timersimulasyon.Tick += timersimulasyon_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 523);
            Controls.Add(lstAlarmlar);
            Controls.Add(pnlIsiticiDurum);
            Controls.Add(pnlVanaDurum);
            Controls.Add(pnlPompaDurum);
            Controls.Add(lblSistemDurum);
            Controls.Add(lblBasinc);
            Controls.Add(lblSicaklik);
            Controls.Add(lblSeviye);
            Controls.Add(prgTankSeviye);
            Controls.Add(btnAlarmSifirla);
            Controls.Add(btnIsitici);
            Controls.Add(btnVana);
            Controls.Add(btnPompa);
            Controls.Add(btnSistemKontrol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSistemKontrol;
        private Button btnPompa;
        private Button btnVana;
        private Button btnIsitici;
        private Button btnAlarmSifirla;
        private ProgressBar prgTankSeviye;
        private Label lblSeviye;
        private Label lblSicaklik;
        private Label lblBasinc;
        private Label lblSistemDurum;
        private Panel pnlPompaDurum;
        private Panel pnlVanaDurum;
        private Panel pnlIsiticiDurum;
        private ListBox lstAlarmlar;
        private System.Windows.Forms.Timer timersimulasyon;
    }
}
