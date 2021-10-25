using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GetEMail
{
    public partial class MultiCatcher : Form
    {
        public MultiCatcher()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            bwBul.RunWorkerAsync();
            btnBul.Enabled = false;
            btnIptal.Enabled = true;
        }

        private void DurumGoster(string yazi, System.Drawing.Color renk)
        {
            toolStripStatusLabel1.Text = "Durum : " + yazi;
            toolStripStatusLabel1.ForeColor = renk;
            if (statusTimer.Enabled)
            {
                statusTimer.Stop();
            }
            statusTimer.Start();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            DurumGoster("İşlem Bekleniyor", Color.DodgerBlue);
        }

        private void bwBul_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<string> siteler = new List<string>(txtSiteler.Lines);
            if (siteler != null && siteler.Count > 0)
            {
                List<string> Epostalar = new List<string>();
                List<string> Telefonlar = new List<string>();
                object[] ilerlemeler = { Epostalar.Count, Telefonlar.Count };
                bwBul.ReportProgress(0, ilerlemeler);
                for (int i = 0; i < siteler.Count; i++)
                {
                    if(bwBul.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    string site = siteler[i];
                    string siteSource = Funcs.GetSource(site);
                    if (!string.IsNullOrEmpty(siteSource))
                    {
                        Epostalar.AddRange(Funcs.GetEMails(siteSource));
                        Telefonlar.AddRange(Funcs.GetPhoneNumbers(siteSource));
                    }
                    ilerlemeler[0] = Epostalar.Count;
                    ilerlemeler[1] = Telefonlar.Count;
                    bwBul.ReportProgress(Convert.ToInt32((100 * (i + 1)) / siteler.Count), ilerlemeler);
                }
                Epostalar = Epostalar.Distinct().ToList();
                Telefonlar = Telefonlar.Distinct().ToList();
                Funcs.Delagate(lstEpostalar, () =>
                {
                    if (Epostalar != null && Epostalar.Count > 0)
                    {
                        lstEpostalar.Items.AddRange(Epostalar.ToArray());
                    }
                });
                Funcs.Delagate(lstTelNumaralari, () =>
                {
                    if (Telefonlar != null && Telefonlar.Count > 0)
                    {
                        lstTelNumaralari.Items.AddRange(Telefonlar.ToArray());
                    }
                });
            }
        }

        private void bwBul_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            string durumYazisi = string.Format("Web Sayfaları içerikleri aranıyor...[İlerleme:%{0} | Bulunan E-Posta :{1} | Bulunan Telefon :{2}]", e.ProgressPercentage, (e.UserState as object[])[0], (e.UserState as object[])[1]);
            DurumGoster(durumYazisi, System.Drawing.Color.DarkOrange);
            prgIlerleme.Value = e.ProgressPercentage;
        }

        private void bwBul_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                DurumGoster("'Web Sayfalarında Bul' işlem kullanıcı tarafından iptal edildi", Color.Red);
            }
            else
            {
                DurumGoster("Arama işlemi tamamlandı", System.Drawing.Color.DarkGreen);
            }
            btnBul.Enabled = true;
            btnIptal.Enabled = false;
        }

        private void cmsLink_Ardisik_Click(object sender, EventArgs e)
        {
            ArdisikFormuGoster();
        }


        private void ArdisikFormuGoster()
        {
            using (ArdisikSayfa frmASayfa = new ArdisikSayfa())
            {
                frmASayfa.ShowDialog();
                if (frmASayfa.OlusturulanSiteler != null && frmASayfa.OlusturulanSiteler is List<string>)
                {
                    foreach (string site in frmASayfa.OlusturulanSiteler)
                    {
                        txtSiteler.AppendText(site);
                        txtSiteler.AppendText(Environment.NewLine);
                    }
                    DurumGoster("Ardışık link(ler) eklendi", Color.DarkGreen);
                }
            }
        }

        private void btnEPKaydet_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "E-Postaları Kaydet";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.Filter = "Metin Dosyası(*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (Funcs.SaveFile(lstEpostalar.Items.Cast<string>().ToList(), sfd.FileName))
                    {
                        DurumGoster("E-Postaları dosyaya aktarma başarılı!", Color.DarkGreen);
                    }
                    else
                    {
                        DurumGoster("E-Postaları dosyaya aktarma başarısız!", Color.Red);
                    }
                }
            }
        }

        private void btnEPTemizle_Click(object sender, EventArgs e)
        {
            Funcs.Delagate(lstEpostalar, () => { lstEpostalar.Items.Clear(); });
            DurumGoster("E-Posta listesi temizlendi!", Color.DarkGreen);
        }

        private void btnEPSecSil_Click(object sender, EventArgs e)
        {
            Funcs.Delagate(lstEpostalar, () =>
            {
                if (lstEpostalar.SelectedIndex != -1)
                {
                    lstEpostalar.Items.RemoveAt(lstEpostalar.SelectedIndex);
                    DurumGoster("E-Posta listesinden seçilen eposta temizlendi!", Color.DarkGreen);
                }
            });
        }

        private void btnTNKaydet_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Telefon Numaralarını Dosyaya Kaydet";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.Filter = "Metin Dosyası(*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (Funcs.SaveFile(lstTelNumaralari.Items.Cast<string>().ToList(), sfd.FileName))
                    {
                        DurumGoster("Telefon Numaralarını dosyaya aktarma başarılı!", Color.DarkGreen);
                    }
                    else
                    {
                        DurumGoster("Telefon Numaralarını dosyaya aktarma başarısız!", Color.Red);
                    }
                }
            }
        }

        private void btnTNTemizle_Click(object sender, EventArgs e)
        {
            Funcs.Delagate(lstTelNumaralari, () => { lstTelNumaralari.Items.Clear(); });
            DurumGoster("Telefon Numaraları listesi temizlendi!", Color.DarkGreen);
        }

        private void btnTNSecSil_Click(object sender, EventArgs e)
        {
            Funcs.Delagate(lstTelNumaralari, () =>
            {
                if (lstTelNumaralari.SelectedIndex != -1)
                {
                    lstTelNumaralari.Items.RemoveAt(lstTelNumaralari.SelectedIndex);
                    DurumGoster("Telefon Numaraları listesinden seçilen eposta temizlendi!", Color.DarkGreen);
                }
            });
        }

        private void lstEpostalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcs.Delagate(btnEPSecSil, () => { btnEPSecSil.Enabled = lstEpostalar.SelectedIndex != -1; });
        }

        private void lstTelNumaralari_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcs.Delagate(btnTNSecSil, () => { btnTNSecSil.Enabled = lstTelNumaralari.SelectedIndex != -1; });
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            bwBul.CancelAsync();
        }

        private void btnArdSayfaEkle_Click(object sender, EventArgs e)
        {
            ArdisikFormuGoster();
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            using (Hakkinda frmHakk = new Hakkinda())
            {
                frmHakk.ShowDialog();
            }
        }
    }
}
