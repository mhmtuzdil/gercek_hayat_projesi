namespace Kütüphane_uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            btnAra = new Button();
            txtBaslik = new TextBox();
            txtYil = new TextBox();
            txtISBN = new TextBox();
            txtYazar = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(336, 285);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(111, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(336, 341);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(111, 29);
            btnAra.TabIndex = 1;
            btnAra.Text = "Ödünç/İade";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(336, 75);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(125, 27);
            txtBaslik.TabIndex = 2;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(336, 236);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(125, 27);
            txtYil.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(336, 184);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(125, 27);
            txtISBN.TabIndex = 4;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(336, 128);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 27);
            txtYazar.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(518, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(870, 324);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "Başlık:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 135);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 8;
            label2.Text = "Yazar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 191);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Basım Yılı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 243);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 10;
            label4.Text = "ISBN No:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 706);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(txtYazar);
            Controls.Add(txtISBN);
            Controls.Add(txtYil);
            Controls.Add(txtBaslik);
            Controls.Add(btnAra);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnAra;
        private TextBox txtBaslik;
        private TextBox txtYil;
        private TextBox txtISBN;
        private TextBox txtYazar;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
