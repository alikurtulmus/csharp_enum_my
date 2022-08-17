using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_enum_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler { Sayı_Giriniz,Adana,Adıyaman,Afyon,Ağrı,Amasya,Ankara,Antalya,Artvin,Aydın}


        private void button1_Click(object sender, EventArgs e)
        {
            int plaka=Convert.ToInt16(textBox1.Text); //textbox'a girdiğimiz değeri int'e çevirip plaka değişkenine atadık
            sehirler s; //sehirler isimli enum dizisinden s değişkeni türettik
            s = (sehirler)plaka; //s değişkeninini sehirler dizisinin plaka değişkenine denk gelen elemanına eşitledik
            //burada da dizilerdeki gibi elemanların indeksleri 0'dan başlıyor. o nedenle ilk elemana (0. indeksteki elemanı) şehir ismi vermedik
            label1.Text = s.ToString();
        }
    }
}
