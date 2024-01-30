using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_okul_projesi_1
{
    public partial class OgrenciOrtalaması : Form
    {
        string Isim;
        string Soyisim;
        int Sifre;
        int Vize1;
        int Vize2;
        int Final;
        public OgrenciOrtalaması(string Isim, string Soyisim, int Sifre, int Vize1, int Vize2, int Final)
        {
            InitializeComponent();
            this.Isim = Isim;
            this.Soyisim = Soyisim;
            this.Sifre = Sifre;
            this.Vize1 = Vize1;
            this.Vize2 = Vize2;
            this.Final = Final;
        }

        private void OgrenciOrtalaması_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama;

            ortalama = (Vize1 * 0.2 + Vize2 * 0.2 + Final * 0.6) / 3;

            lbl_ogrenci_ortalama.Text = ortalama.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
