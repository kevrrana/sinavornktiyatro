using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınavornek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatroListesi = new List<Tiyatro>();
        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroListesi.Add(new Tiyatro(1, "Cadı Kazanı", 120, 100, new DateTime(2024, 11, 1), "Beylikdüzü Fatih Sultan Mehmet Kültür Sanat Merkezi Rasim Öztekin Sahnesi", true));
            tiyatroListesi.Add(new Tiyatro(2, "Fındıkkıran", 80, 90, new DateTime(2023, 7, 12), "Fatih Reşat Nuri Sahnesi", false));
            tiyatroListesi.Add(new Tiyatro(3, "Fosforlu Cevriye", 190, 160, new DateTime(2024, 9, 2), "Gaziosmanpaşa Sahnesi", true));
            tiyatroListesi.Add(new Tiyatro(4, "Oscar", 110, 100, new DateTime(2023, 10, 21), "Harbiye Muhsin Ertuğrul Sahnesi", true));
            tiyatroListesi.Add(new Tiyatro(5, "İfigenya", 130, 110, new DateTime(2024, 1, 10), "Kağıthane Sadabad Sahnesi", true));
            tiyatroListesi.Add(new Tiyatro(6, "Fosforlu Cevriye", 75, 80, new DateTime(2023, 8, 12), "Müze Gazhane Meydan Sahne", false));

            dgvListe.DataSource = tiyatroListesi;

        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOyunId.Text = dgvListe.CurrentRow.Cells["oyunid"].Value.ToString();
            txtOyunAd.Text = dgvListe.CurrentRow.Cells["oyunad"].Value.ToString();
            nmSure.Value =Convert.ToInt32(dgvListe.CurrentRow.Cells["sure"].Value);
            txtFiyat.Text = dgvListe.CurrentRow.Cells["fiyat"].Value.ToString();
            dtpOyunTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["oyuntarih"].Value;
            cmbSahne.Text = dgvListe.CurrentRow.Cells["sahne"].Value.ToString();
            chkMuzikal.Checked = (bool)dgvListe.CurrentRow.Cells["muzikal"].Value;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int oyunid=Convert.ToInt32(txtOyunId.Text);
            string oyunad = txtOyunAd.Text;
            double fiyat=Convert.ToInt32(txtFiyat.Text);
            DateTime oyuntarih = dtpOyunTarih.Value;
            string sahne = cmbSahne.Text;
            bool muzikal=chkMuzikal.Checked;
            int sure=Convert.ToInt32(nmSure.Text);

            Tiyatro yeniTiyatro = new Tiyatro(oyunid, oyunad, sure, fiyat, oyuntarih, sahne, muzikal);
           
            
            tiyatroListesi.Add(yeniTiyatro);
            dgvListe.DataSource = tiyatroListesi.ToList();


        }

        private void btnGüncele_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro=secilenSatir.DataBoundItem as Tiyatro;

            int oyunid = Convert.ToInt32(txtOyunId.Text);
            string oyunad = txtOyunAd.Text;
            double fiyat = Convert.ToInt32(txtFiyat.Text);
            DateTime oyuntarih = dtpOyunTarih.Value;
            string sahne = cmbSahne.Text;
            bool muzikal = chkMuzikal.Checked;
            int sure = Convert.ToInt32(nmSure.Text);


            secilenTiyatro.Oyunid = oyunid;
            secilenTiyatro.Oyunad=oyunad;
            secilenTiyatro.Sure = sure;
            secilenTiyatro.Fiyat = fiyat;
            secilenTiyatro.Oyuntarih=oyuntarih;
            secilenTiyatro.Sahne=sahne;
            secilenTiyatro.Muzikal=muzikal;

            dgvListe.DataSource = null;
            dgvListe.DataSource = tiyatroListesi.ToList();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro = secilenSatir.DataBoundItem as Tiyatro;

            DialogResult result = MessageBox.Show("Seçilen Tiyatro Bilgileri Silinsin mi?", "Tiyatro Bilgisini Sil",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                tiyatroListesi.Remove(secilenTiyatro);
            }
            dgvListe.DataSource = tiyatroListesi.ToList();


        }
    }
}
