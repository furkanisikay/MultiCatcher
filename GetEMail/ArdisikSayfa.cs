using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetEMail
{
    public partial class ArdisikSayfa : Form
    {
        public ArdisikSayfa()
        {
            InitializeComponent();
        }

        public List<string> OlusturulanSiteler { get; private set; }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OlusturulanSiteler = ArdisikSiteleriOlustur(txtSite.Text);
            this.Close();
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            List<string> siteler = ArdisikSiteleriOlustur(txtSite.Text);
            using (ArdisikSayfaOnizleme frmOnizleme= new ArdisikSayfaOnizleme(siteler))
            {
                frmOnizleme.ShowDialog();
            }
        }

        private List<string> ArdisikSiteleriOlustur(string site)
        {
            List<string> siteler = new List<string>();
            string kalip = site.Replace("#ardışık#", "{0}");
            for (int i = Convert.ToInt32(nudBaslangic.Value); i <= nudBitis.Value; i++)
            {
                siteler.Add(string.Format(kalip, i));
            }
            return siteler;
        }
    }
}
