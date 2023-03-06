using Otel.UI.Common;
using Otel.UI.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Otel.UI
{

	public partial class FrmRapor : Form
	{
		public FrmRapor()
		{
			InitializeComponent();
		}
		public List<Rezervasyon> _rezervasyonlar = null;
		private void FrmRapor_Load(object sender, EventArgs e)
		{
			TabloyuDoldur();
		}

		private void TabloyuDoldur()
		{
			FiltrelemeYap();

		}

		private void btnTarihFiltrele_Click(object sender, EventArgs e)
		{
			FiltrelemeYap(x=> x.GirisTarihi.Date >= dtpGirisTarihi.Value.Date && x.CikisTarihi.Date <= dtpCikisTarihi.Value.Date);
		}

		private void FiltrelemeYap(Predicate<Rezervasyon> sorgu=null)
		{
			List<Rezervasyon> filtreRezervasyon = sorgu==null
				?_rezervasyonlar
				: _rezervasyonlar.FindAll(sorgu);

			lstRapor.Items.Clear();
			int sayac = 0;
			foreach (var item in filtreRezervasyon)
			{
				ListViewItem lw = new ListViewItem();
				lw.Text = (++sayac).ToString();
				lw.SubItems.Add(item.Oda.KatNumarasi.ToString());
				lw.SubItems.Add(item.Oda.OdaNumarasi.ToString());
				lw.SubItems.Add(item.Oda.OdaDurumu.ToString());
				lw.SubItems.Add(item.Musteri.MusteriAdi + " " + item.Musteri.MusteriSoyadi);
				lw.SubItems.Add(item.Musteri.TcNumarasi);
				lw.SubItems.Add(item.Musteri.TelefonNumarasi);
				lw.SubItems.Add(item.GirisTarihi.ToString());
				lw.SubItems.Add(item.CikisTarihi.ToString());
				lw.SubItems.Add(item.RezarvasyonUcreti.ToString());
				lw.Tag = item;
				lstRapor.Items.Add(lw);
			}
		}

		private void btnTumListe_Click(object sender, EventArgs e)
		{
			FiltrelemeYap();
		}

		private void btnFitrele_Click(object sender, EventArgs e)
		{
			if (Validasyon())
			{
				FiltrelemeYap(x => x.Musteri.MusteriAdi.ToLower().Contains(txtArancakKelime.Text.ToLower()));
			}
			else
			{
				MessageBox.Show("Lütfen Arama Kutusunu boş bırakmayın");
			}
		}
		private bool Validasyon()
		{
			return ValidationTool.BosMu(txtArancakKelime.Text) && ValidationTool.SayiVarMi(txtArancakKelime.Text);
		}
	}
}
