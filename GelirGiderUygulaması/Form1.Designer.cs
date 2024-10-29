namespace GelirGiderUygulaması
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BtnHesapla = new Button();
            BtnExcel = new Button();
            TxtTur = new TextBox();
            BtnKaydet = new Button();
            TxtTutar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 102);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 0;
            label1.Text = "Tutar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 149);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 1;
            label2.Text = "Tür :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 38);
            label3.Name = "label3";
            label3.Size = new Size(273, 32);
            label3.TabIndex = 4;
            label3.Text = "Gelir-Gider Tablosu";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(310, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(403, 268);
            dataGridView1.TabIndex = 5;
            // 
            // BtnHesapla
            // 
            BtnHesapla.BackColor = Color.Chocolate;
            BtnHesapla.FlatStyle = FlatStyle.Flat;
            BtnHesapla.Location = new Point(129, 325);
            BtnHesapla.Name = "BtnHesapla";
            BtnHesapla.Size = new Size(140, 46);
            BtnHesapla.TabIndex = 8;
            BtnHesapla.Text = "Hesapla";
            BtnHesapla.UseVisualStyleBackColor = false;
            BtnHesapla.Click += BtnHesapla_Click;
            // 
            // BtnExcel
            // 
            BtnExcel.BackColor = Color.DarkKhaki;
            BtnExcel.FlatStyle = FlatStyle.Flat;
            BtnExcel.Location = new Point(129, 273);
            BtnExcel.Name = "BtnExcel";
            BtnExcel.Size = new Size(140, 46);
            BtnExcel.TabIndex = 7;
            BtnExcel.Text = "EXCEL";
            BtnExcel.UseVisualStyleBackColor = false;
            BtnExcel.Click += BtnExcel_Click;
            // 
            // TxtTur
            // 
            TxtTur.BorderStyle = BorderStyle.FixedSingle;
            TxtTur.Location = new Point(129, 148);
            TxtTur.Name = "TxtTur";
            TxtTur.Size = new Size(140, 39);
            TxtTur.TabIndex = 3;
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackColor = Color.Silver;
            BtnKaydet.FlatStyle = FlatStyle.Flat;
            BtnKaydet.Location = new Point(129, 221);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(140, 46);
            BtnKaydet.TabIndex = 6;
            BtnKaydet.Text = "Ekle";
            BtnKaydet.UseVisualStyleBackColor = false;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // TxtTutar
            // 
            TxtTutar.BorderStyle = BorderStyle.FixedSingle;
            TxtTutar.Location = new Point(129, 103);
            TxtTutar.Name = "TxtTutar";
            TxtTutar.Size = new Size(140, 39);
            TxtTutar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1035, 454);
            Controls.Add(BtnHesapla);
            Controls.Add(BtnExcel);
            Controls.Add(BtnKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(TxtTur);
            Controls.Add(TxtTutar);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button BtnHesapla;
        private Button BtnExcel;
        private TextBox TxtTur;
        private Button BtnKaydet;
        private TextBox TxtTutar;
    }
}
