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
    public partial class Form1 : Form
    {
        List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenciler.Add(new Ogrenci("kemal ", "demir ", 123, 35, 67, 100));
            Ogrenciler.Add(new Ogrenci("ali ", "yıldız ", 234, 45, 89, 68));
            Ogrenciler.Add(new Ogrenci("mahmut ", "demir ", 345, 79, 67, 100));
            Ogrenciler.Add(new Ogrenci("ismail ", "candaş ", 456, 76, 80, 80));
            Ogrenciler.Add(new Ogrenci("aynjr ", "güneş ", 567, 35, 67, 67));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifre;

            sifre = Convert.ToInt32(txt_sifre.Text.Trim());

            Ogrenci hedefogrenci;
            bool kontrol = false;
            foreach (Ogrenci ogrenci in Ogrenciler)
            {
                if(sifre == ogrenci.getsifre())
                {
                    kontrol = true;
                    hedefogrenci = ogrenci;

                    string İsim = hedefogrenci.getisim();
                    string Soyisim = hedefogrenci.getsoyisim();
                    int Sifre = hedefogrenci.getsifre();
                    int vize1 = hedefogrenci.getvize1();
                    int vize2 = hedefogrenci.getvize2();
                    int Final = hedefogrenci.getfinal();


                    GirisSayfasi gir = new GirisSayfasi(İsim ,Soyisim , Sifre , vize1 , vize2 , Final );
                    gir.Show();
                    this.Hide();
                    break;


                }
            }

            if(!kontrol)
            {
                MessageBox.Show("Girilen şifre yanlış , lütfen tekrar deneyin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
