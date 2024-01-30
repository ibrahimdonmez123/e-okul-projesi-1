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
    public partial class OgrenciBilgileri : Form
    {
        string Isim;
        string Soyisim;
        int Sifre;
        int Vize1;
        int Vize2;
        int Final;
        public OgrenciBilgileri(string Isim, string Soyisim, int Sifre, int Vize1, int Vize2, int Final)
        {
            InitializeComponent();
            this.Isim = Isim;
            this.Soyisim = Soyisim;
            this.Sifre = Sifre;
            this.Vize1 = Vize1;
            this.Vize2 = Vize2;
            this.Final = Final;
        }

        private void OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            lbl_isim.Text = Isim;   
            lbl_soyisim.Text = Soyisim;
            lbl_sifre.Text = Sifre.ToString();
            lbl_vize1.Text = Vize1.ToString();
            lbl_vize2.Text = Vize2.ToString();  
            lbl_final.Text = Final.ToString();  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
