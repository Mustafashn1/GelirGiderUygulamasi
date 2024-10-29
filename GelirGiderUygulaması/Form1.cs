using System.Data;
using System.Runtime.CompilerServices;

namespace GelirGiderUygulaması
{
    public partial class Form1 : Form
    {
        private DataTable tablo;
        public Form1()
        {
            InitializeComponent();

            tablo = new DataTable();
            tablo.Columns.Add("Harcama Türü", typeof(string));
            tablo.Columns.Add("Harcama Tutarı", typeof(string));
            dataGridView1.DataSource = tablo;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string harcamaTuru = TxtTur.Text;
            string harcamaTutari = TxtTutar.Text;


            tablo.Rows.Add(harcamaTuru, harcamaTutari);
            TxtTur.Clear();
            TxtTutar.Clear();

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            var tutar = TxtTutar.Text;


        }
    }
}
