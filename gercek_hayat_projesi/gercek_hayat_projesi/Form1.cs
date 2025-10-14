namespace gercek_hayat_projesi
{
    public partial class Form1 : Form
    {
        int idsayac = 1;    // sayaç 0 dan deðil birden baþlasýn
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
            cmb_lokasyon.Items.Add("Fabrika1");   //adres belirtme
            cmb_lokasyon.Items.Add("Fabrika2");
            cmb_lokasyon.Items.Add("Fabrika3");
            cmb_lokasyon.Items.Add("Ofis1");
            cmb_lokasyon.Items.Add("Depo1");

            dataGridView1.Columns.Add("ID", "ID");                //sütun oluþturma
            dataGridView1.Columns.Add("Ýsim", "Ýsim");
            dataGridView1.Columns.Add("Lokasyon", "Lokasyon");


        }
        private void btn_yukle_Click(object sender, EventArgs e)
        {
            if (txt_isim.Text.Length == 0)                                 //isim girilmemiþse uyarý versin
            {
                MessageBox.Show("Lütfen bir isim giriniz.");
                return;
            }
            if (cmb_lokasyon.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir lokasyon seçiniz.");              //lokasyon seçilmemiþse uyarý versin
                return;
            }
            dataGridView1.Rows.Add(idsayac, txt_isim.Text.ToString(), cmb_lokasyon.Text.ToString()); //gridview a verileri yazdýrma 
            idsayac++; //sayaç her butona bastýktan sonra bir artsýn
            txt_isim.Clear(); //veri gönderildikten sonra textboxu sýfýrlasýn
            cmb_lokasyon.SelectedIndex = -1;  //veri gönderildikten sonra combobox ý sýfýrlasýn
            txt_isim.Focus();//buttona basýlýp veriler gönderildikten sonra imleci texte fokuslasýn
        }

        private void txt_isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabla geçiþ yapma (propertiesden yaptým)
        }
    }
}
