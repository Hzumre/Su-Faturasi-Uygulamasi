using SuFaturası.Entities.Entities;
using SuFaturası.Entities.Enums;

namespace WFA_SuFaturası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new();
            yeniKullanici.AdSoyad = txtAdSoyad.Text;
            yeniKullanici.SonIndex = Convert.ToDouble( txtSonIndex.Text);
            yeniKullanici.IlkIndex = Convert.ToDouble(txtIlkIndex.Text);
            yeniKullanici.KullanimYeri = rdMesken.Checked ? KullanimYeri.Mesken : KullanimYeri.Umumi;

            lstAdSoyad.Items.Add(yeniKullanici.AdSoyad);

            SuFaturasi suFaturasi = new();
            suFaturasi.Kullanici = yeniKullanici;
            decimal faturaTutari = Convert.ToDecimal(suFaturasi.Tutar);

            //lstKSuMiktari.Items.Add(suFaturasi.KullanilanSuMiktari);
            lstFaturaTutari.Items.Add(suFaturasi.Tutar);

            MessageBox.Show($"Fatura Tutarınız: {String.Format("{0:C1}", faturaTutari)  }");
        }
    }
}