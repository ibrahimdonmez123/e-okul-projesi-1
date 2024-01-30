using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_okul_projesi_1
{
    public  class Ogrenci
    {


        public string isim { get; set; }
        public string soyisim { get; set; }
        public int sifre { get; set; }
        public int vize1 { get; set; }
        public int vize2 { get; set; }
        public int final { get; set; }

        public Ogrenci()
        {

        }
        public Ogrenci(string isim , string soyisim , int sifre , int vize1 , int vize2 , int  final)
        {
            this.isim = isim;
            this.soyisim= soyisim;
            this.sifre = sifre;
            this.vize1 = vize1;
            this.vize2 = vize2; 
            this.final = final;
        }


        public void setisim()
        {
            this.isim = isim;
        }

        public string getisim()
        {
            return this.isim;
        }

        public void setsoyisim()
        {
            this.soyisim= soyisim;
        }
        public string getsoyisim()
        {
            return this.soyisim;
        }

        public void setsifre()
        {
            this.sifre = sifre;
        }

        public int getsifre()
        {
            return this.sifre;
        }

        public void setvize1()
        {
            this.vize1 = vize1;
        }

        public int getvize1()
        {
            return this.vize2;
        }
        public void setvize2()
        {
            this.vize2 = vize2; 
        }

        public int getvize2()
        {
            return this.vize2;
        }
        public void setfinal()
        {
            this.final= final;  
        }
        public int getfinal()
        {
            return this.final;
        }
    }
}
