namespace gemini_task_review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);


            int cift = Ciftadet(baslangic, bitis);
            int tek = teksayitoplam(baslangic, bitis);

            richTextBox1.AppendText("Çift Adet:" + cift + "\n");
            richTextBox1.AppendText("Tek Sayý Toplamý:" + tek + "\n");
            for (int i = baslangic; i <= bitis; i++)
            {
                if (baslangic > bitis)
                {
                    MessageBox.Show("Baþlangýç Sayýsý Bitiþ Sayýsýndan Büyük Olamaz");
                    return;
                }

            }

           
        }
        public static int Ciftadet(int baslangic, int bitis)
        {
            int sayac = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 == 0)
                {
                    sayac++;
                }

            }
            return sayac;
        }
        public static int teksayitoplam(int baslangic, int bitis)
        {
            int toplam = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 != 0) toplam += i;
            }
            return toplam;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int carpim = Convert.ToInt16(textBox3.Text);
            
            for(int carpan = 1; carpan <=10;carpan++)
            {

                richTextBox1.AppendText($"{carpim} x {carpan} = {carpim * carpan}\n");
            }
        }
    }
}
