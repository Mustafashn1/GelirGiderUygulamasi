using OfficeOpenXml;
using System.Data;

namespace GelirGiderUygulaması
{
    public partial class Form1 : Form
    {
        private DataTable? _tablo;
        public Form1()
        {
            InitializeComponent();
            _tablo = new DataTable();
            GelirGiderTablosu();
        }

        private void GelirGiderTablosu()
        {
            _tablo = new DataTable();
            _tablo.Columns.Add("Tür", typeof(string));
            _tablo.Columns.Add("Tutar", typeof(decimal));
            dataGridView1.DataSource = _tablo;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTur.Text) || string.IsNullOrWhiteSpace(TxtTutar.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (decimal.TryParse(TxtTutar.Text, out decimal tutar))
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                _tablo.Rows.Add(TxtTur.Text, tutar);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                TxtTur.Clear();
                TxtTutar.Clear();
            }
            else
            {
                MessageBox.Show("Geçerli bir tutar girin.");
            }

        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; 

            using (var saveFileDialog = new SaveFileDialog() { Filter = "Excel Dosyası|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new ExcelPackage())
                    {
                        var sheet = package.Workbook.Worksheets.Add("GelirGider");
                        sheet.Cells["A1"].LoadFromDataTable(_tablo, true);
                        File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                        MessageBox.Show("Veriler Excel dosyasına aktarıldı.");
                    }
                }
            }
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            decimal toplamGelir = 0;
            decimal toplamGider = 0;

            if (_tablo != null)
            {
                foreach (DataRow row in _tablo.Rows)
                {
                    string tur = row["Tür"]?.ToString() ?? string.Empty;
                    decimal tutar = Convert.ToDecimal(row["Tutar"]);

                    if (tur == "Gelir")
                        toplamGelir += tutar;
                    else if (tur == "Gider")
                        toplamGider += tutar;
                }
            }

            decimal bakiye = toplamGelir - toplamGider;

            // Daha önce eklenmiş "Toplam" satırı varsa, önce kaldırıyoruz
#pragma warning disable CS8604 // Possible null reference argument.
            var toplamTutari = _tablo.AsEnumerable()
                                  .FirstOrDefault(r => r.Field<string>("Tür") == "Toplam");
#pragma warning restore CS8604 // Possible null reference argument.
            if (toplamTutari != null)
            {
                _tablo.Rows.Remove(toplamTutari);
            }

            // Yeni "Toplam" satırı ekliyoruz

            _tablo.Rows.Add("Bakiye", bakiye);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
