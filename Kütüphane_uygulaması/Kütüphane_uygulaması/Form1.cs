using System.Drawing;

namespace Kütüphane_uygulaması
{
    public partial class Form1 : Form
    {
        private Kitap[] kitaplar = new Kitap[10];
        private int kitapSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void KitapListele()
        {
            listBox1.Items.Clear();


            for (int i = 0; i < kitapSayisi; i++)
            {

                listBox1.Items.Add(kitaplar[i]);
                string listelenecekMetin = kitaplar[i].Oku_KitapBilgileri();

                listBox1.Items.Add(listelenecekMetin);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBaslik.Text) || string.IsNullOrEmpty(txtISBN.Text) || !int.TryParse(txtYil.Text, out int yil)) //ia dan aldım
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun (Yayın Yılı sayı olmalıdır).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kitapSayisi < kitaplar.Length)
            {

                Kitap yeniKitap = new Kitap(txtBaslik.Text, txtYazar.Text, txtISBN.Text, yil);


                kitaplar[kitapSayisi] = yeniKitap;
                kitapSayisi++;


                KitapListele();
                MessageBox.Show("Kitap başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtBaslik.Clear();
                txtYazar.Clear();
                txtISBN.Clear();
                txtYil.Clear();
            }
            else
            {
                MessageBox.Show("Kütüphane dolu. Daha fazla kitap eklenemiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen listeden bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Kitap secilenKitap = (Kitap)listBox1.SelectedItem; 



            for (int i = 0; i < kitapSayisi; i++)
            {
                
                if (kitaplar[i].ISBN == secilenKitap.ISBN)
                {
                    
                    kitaplar[i].Durum = !kitaplar[i].Durum;

                    string islem = kitaplar[i].Durum ? "iade edildi " : "ödünç alındı ";
                    MessageBox.Show($"'{kitaplar[i].Baslik}' kitabı başarıyla {islem}.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    KitapListele();
                    return;
                }
            }

            
            MessageBox.Show("Kitap dizide bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
