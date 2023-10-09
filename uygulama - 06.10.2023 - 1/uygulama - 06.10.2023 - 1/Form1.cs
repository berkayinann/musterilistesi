namespace uygulama___06._10._2023___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KisileriListele();
        }
        public List<musteri> musteriListesi = new List<musteri>();

        private void KisileriListele()
        {
            listcustomer.Items.Clear();
            foreach (musteri musteri in musteriListesi)
            {
                listcustomer.Items.Add(musteri.Adsoyad);
            }
        }
        public void btnnewcustomer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(musteriListesi);
            form2.ShowDialog();
            KisileriListele();

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            KisileriListele();
        }
        public void listcustomer_DoubleClick(object sender, EventArgs e)
        {
            if (listcustomer.SelectedIndex != -1)
            {
                int index = listcustomer.SelectedIndex;
                musteri musteri = musteriListesi[index];

                MessageBox.Show($"Ad Soyad : {musteri.Adsoyad}\nYaş : {musteri.Yas}\nAdres :" +
                    $" {musteri.Adres}\nTelefon : {musteri.Telefon}", "Müşteri Bilgileri",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                listcustomer.SelectedIndex = - 1;
            }

        }




    }
}
