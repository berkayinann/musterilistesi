namespace uygulama___06._10._2023___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<musteri> musteriListesi = new List<musteri>();
        public void btnnewcustomer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            musteri yeniMusteri = new musteri(form2);
            musteriListesi.Add(yeniMusteri);
            listcustomer.Items.Add($"{yeniMusteri.Adsoyad}");

            form2.ShowDialog();

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            listcustomer.Items.Add(musteriListesi);
            listcustomer.Show();
            

            foreach (musteri musteri in musteriListesi)
            {
                listcustomer.Items.Add($"{musteri.Adsoyad} ");
            }

        }

        public void lstMusteriListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilenMusteri = listcustomer.SelectedItem.ToString();
            listcustomer.Text = secilenMusteri;
        }

        public void listcustomer_DoubleClick(object sender, EventArgs e)
        {
            string secilenMusteri = listcustomer.SelectedItem.ToString();
            MessageBox.Show($"Müşteri Bilgileri:{secilenMusteri}");

        }




    }
}
