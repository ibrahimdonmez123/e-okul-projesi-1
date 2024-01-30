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
    public partial class GirisSayfasi : Form
    {

        string Isim;
        string Soyisim;
        int Sifre;
        int Vize1;
        int Vize2;
        int Final;
        public GirisSayfasi( string Isim , string Soyisim, int Sifre , int Vize1 , int Vize2 , int Final)
        {
            InitializeComponent();
            this.Isim = Isim;
            this.Soyisim = Soyisim;
            this.Sifre= Sifre;
            this.Vize1= Vize1;  
            this.Vize2 = Vize2;
            this.Final = Final; 
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ogrencibilgileri = new OgrenciBilgileri( Isim , Soyisim , Sifre , Vize1 , Vize2 , Final);
            ogrencibilgileri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this .Hide();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciOrtalaması ogrenciortalamasi = new OgrenciOrtalaması(Isim , Soyisim , Sifre , Vize1 , Vize2 , Final);

            ogrenciortalamasi.Show();
            this.Hide();
        }
    }
}
