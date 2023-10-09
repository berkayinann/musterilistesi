using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama___06._10._2023___1
{
    
    public partial class Form2 : Form
    {
        List<musteri> musterilistesi;
        public Form2(List<musteri> musterilistesi)
        {
            InitializeComponent();
            this.musterilistesi = musterilistesi;
        }

        public void btnkaydet_Click(object sender, EventArgs e)
        {
            musteri musteri = new musteri();
            musteri.Adsoyad = txtadsoyad.Text.Trim();
            musteri.Telefon = txttelefon.Text.Trim();
            musteri.Yas = (int)nudyas.Value;
            musteri.Adres = txtadres.Text.Trim();
            musterilistesi.Add(musteri);
            musteritemizle();
        }

        public void musteritemizle()
        {
            txtadsoyad.Clear();
            txttelefon.Clear();
            txtadres.Clear();
            nudyas.Value = 0;
        }


        public void btnlisteyedon_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
