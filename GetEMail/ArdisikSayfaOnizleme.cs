using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GetEMail
{
    public partial class ArdisikSayfaOnizleme : Form
    {
        public ArdisikSayfaOnizleme(List<string> siteler)
        {
            InitializeComponent();
            textBox1.Lines = siteler.ToArray();
        }

        private void ArdisikSayfaOnizleme_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { this.Close(); }
        }
    }
}
