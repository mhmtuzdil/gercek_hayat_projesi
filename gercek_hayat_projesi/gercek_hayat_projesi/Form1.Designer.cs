namespace gercek_hayat_projesi
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
            btn_yukle = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_isim = new TextBox();
            cmb_lokasyon = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_yukle
            // 
            btn_yukle.Location = new Point(145, 248);
            btn_yukle.Name = "btn_yukle";
            btn_yukle.Size = new Size(151, 29);
            btn_yukle.TabIndex = 0;
            btn_yukle.Text = "Yükle";
            btn_yukle.UseVisualStyleBackColor = true;
            btn_yukle.Click += btn_yukle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 61);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 143);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Lokasyon:";
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(145, 54);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(151, 27);
            txt_isim.TabIndex = 3;
            txt_isim.KeyPress += txt_isim_KeyPress;
            // 
            // cmb_lokasyon
            // 
            cmb_lokasyon.FormattingEnabled = true;
            cmb_lokasyon.Location = new Point(145, 135);
            cmb_lokasyon.Name = "cmb_lokasyon";
            cmb_lokasyon.Size = new Size(151, 28);
            cmb_lokasyon.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HotTrack;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(439, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(506, 342);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1268, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cmb_lokasyon);
            Controls.Add(txt_isim);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_yukle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_yukle;
        private Label label1;
        private Label label2;
        private TextBox txt_isim;
        private ComboBox cmb_lokasyon;
        private DataGridView dataGridView1;
    }
}
