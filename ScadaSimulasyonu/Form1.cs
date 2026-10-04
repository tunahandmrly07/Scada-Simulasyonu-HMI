using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScadaSimulasyonu
{
    public partial class Form1 : Form
    {
        
        private bool sistemCalisiyor = false;  
        private bool pompaCalisiyor = false;    
        private bool vanaAcik = false;        
        private bool isiticiCalisiyor = false;  

        private double tankSeviye = 25.0;       
        private double sicaklik = 22.0;        
        private double basinc = 1.0;            

        private Random rastgele = new Random(); 

       
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (timersimulasyon != null)
            {
                timersimulasyon.Interval = 1000;
                timersimulasyon.Enabled = false;
            }

            
            ArayuzGuncelle();
            AlarmKaydet("SİSTEM: SCADA Operatör Paneli kullanıma hazır.");
        }

        

        
        private void btnSistemKontrol_Click(object sender, EventArgs e)
        {
            sistemCalisiyor = !sistemCalisiyor; 

            Button btn = sender as Button;

            if (sistemCalisiyor)
            {
                timersimulasyon.Start(); 

                if (btn != null)
                {
                    btn.Text = "Sistemi Durdur";
                    btn.BackColor = Color.LightGreen;
                }
                AlarmKaydet("OPERATÖR: Sistem çalıştırıldı.");
            }
            else
            {
                timersimulasyon.Stop(); 

                if (btn != null)
                {
                    btn.Text = "Sistemi Başlat";
                    btn.BackColor = SystemColors.Control;
                }
                AlarmKaydet("OPERATÖR: Sistem durduruldu.");
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            btnSistemKontrol_Click(sender, e);
        }

        
        private void btnPompa_Click(object sender, EventArgs e)
        {
            if (!sistemCalisiyor)
            {
                MessageBox.Show("Sistem çalışır durumda değilken pompa açılamaz!", "Emniyet Kilidi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pompaCalisiyor = !pompaCalisiyor;

            
            pnlPompaDurum.BackColor = pompaCalisiyor ? Color.LimeGreen : Color.Gray;

            AlarmKaydet(pompaCalisiyor ? "CİHAZ: Besleme pompası devreye alındı." : "CİHAZ: Besleme pompası durduruldu.");
        }

       
        private void btnVana_Click(object sender, EventArgs e)
        {
            if (!sistemCalisiyor)
            {
                MessageBox.Show("Sistem çalışır durumda değilken vana açılamaz!", "Emniyet Kilidi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            vanaAcik = !vanaAcik;

            
            pnlVanaDurum.BackColor = vanaAcik ? Color.LimeGreen : Color.Gray;

            AlarmKaydet(vanaAcik ? "CİHAZ: Boşaltma vanası açıldı." : "CİHAZ: Boşaltma vanası kapatıldı.");
        }

        
        private void btnIsitici_Click(object sender, EventArgs e)
        {
            if (!sistemCalisiyor)
            {
                MessageBox.Show("Sistem çalışır durumda değilken ısıtıcı açılamaz!", "Emniyet Kilidi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isiticiCalisiyor = !isiticiCalisiyor;

            
            pnlIsiticiDurum.BackColor = isiticiCalisiyor ? Color.OrangeRed : Color.Gray;

            AlarmKaydet(isiticiCalisiyor ? "CİHAZ: Isıtıcı rezistans aktif edildi." : "CİHAZ: Isıtıcı rezistans kapatıldı.");
        }

       
        private void btnAlarmSifirla_Click(object sender, EventArgs e)
        {
            lblSistemDurum.Text = "SİSTEM NORMAL";
            lblSistemDurum.ForeColor = Color.DarkGreen;
            lblSistemDurum.BackColor = Color.Transparent;

            AlarmKaydet("OPERATÖR: Alarmlar onaylandı ve sıfırlandı.");
        }

        
        private void timersimulasyon_Tick(object sender, EventArgs e)
        {
            FizikselDavranisHesapla(); 
            AlarmKontrolEt();          
            ArayuzGuncelle();           
        }

        
        private void FizikselDavranisHesapla()
        {
            
            if (pompaCalisiyor)
            {
                tankSeviye += 3.0 + (rastgele.NextDouble() * 0.8);
            }

           
            if (vanaAcik)
            {
                tankSeviye -= 2.5 + (rastgele.NextDouble() * 0.5);
            }

           
            if (tankSeviye > 100.0) tankSeviye = 100.0;
            if (tankSeviye < 0.0) tankSeviye = 0.0;

            
            if (isiticiCalisiyor)
            {
                sicaklik += 1.8 + (rastgele.NextDouble() * 0.4);
            }
            else if (sicaklik > 22.0)
            {
                sicaklik -= 0.6; 
            }

            
            basinc = 1.0 + (tankSeviye * 0.04) + ((sicaklik - 20.0) * 0.035);
        }

        
        private void AlarmKontrolEt()
        {
            bool kritikAlarmVar = false;
            string alarmMesaji = "";

            
            if (tankSeviye >= 90.0)
            {
                kritikAlarmVar = true;
                alarmMesaji = "KRİTİK: Yüksek Tank Seviyesi (%90 Üstü)!";
            }
            else if (tankSeviye <= 10.0)
            {
                kritikAlarmVar = true;
                alarmMesaji = "UYARI: Düşük Tank Seviyesi (%10 Altı)!";
            }

            if (sicaklik >= 85.0)
            {
                kritikAlarmVar = true;
                alarmMesaji += (alarmMesaji == "" ? "" : " | ") + "KRİTİK: Aşırı Sıcaklık (>85°C)!";
            }

            if (basinc >= 6.5)
            {
                kritikAlarmVar = true;
                alarmMesaji += (alarmMesaji == "" ? "" : " | ") + "TEHLİKE: Yüksek Basınç (>6.5 bar)!";
            }
            
            if (kritikAlarmVar)
            {
                lblSistemDurum.Text = alarmMesaji;
                lblSistemDurum.ForeColor = Color.White;
                lblSistemDurum.BackColor = Color.Red;

                if (lstAlarmlar.Items.Count == 0 || !lstAlarmlar.Items[lstAlarmlar.Items.Count - 1].ToString().Contains(alarmMesaji))
                {
                    AlarmKaydet(alarmMesaji);
                }
            }
        }
        private void AlarmKaydet(string mesaj)
        {
            string zaman = DateTime.Now.ToString("HH:mm:ss");
            lstAlarmlar.Items.Add($"[{zaman}] {mesaj}");
            lstAlarmlar.TopIndex = lstAlarmlar.Items.Count - 1; 
        }

      
        private void ArayuzGuncelle()
        {
            
            prgTankSeviye.Value = (int)Math.Round(tankSeviye);

           
            lblSeviye.Text = $"% {tankSeviye:F1}";
            lblSicaklik.Text = $"{sicaklik:F1} °C";
            lblBasinc.Text = $"{basinc:F2} bar";

           
            lblSeviye.ForeColor = (tankSeviye >= 90.0 || tankSeviye <= 10.0) ? Color.Red : Color.Black;
            lblSicaklik.ForeColor = (sicaklik >= 85.0) ? Color.Red : Color.Black;
            lblBasinc.ForeColor = (basinc >= 6.5) ? Color.Red : Color.Black;
        }
    }
}
