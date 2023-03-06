using Otel.UI.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Otel.UI
{
	public partial class FrmFaturalandirma : Form
	{
		public List<Rezervasyon> _rezervasyonlar = null;
		public FrmFaturalandirma()
		{
			InitializeComponent();

		}
		private void FrmFaturalandirma_Load(object sender, EventArgs e)
		{
			HizmetleriOlustur();
			MusterileriDoldur();
		}
		// rezervasyon yapan müşteriler comboboxa eklenir
		private void MusterileriDoldur()
		{
			foreach (var item in _rezervasyonlar)
			{
				cmbMusteriler.Items.Add(item.Musteri);
			}
		}
		private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
		{
			RezervasyonuBul();
		}

		// Ek hizmetler için flowlayout paneline checboxlar eklenir
		private void HizmetleriOlustur()
		{
			flwHizmetler.Controls.AddRange
				(
					new CheckBox[]
					{
						new CheckBox()
						{
							Text="Tableron",
							Tag= new Hizmet(){HizmetAdi="Tableron",HizmetFiyati=15}
						},
						new CheckBox()
						{
							Text="Kuruyemiş",
							Tag= new Hizmet(){HizmetAdi="Kuruyemiş",HizmetFiyati=50}
						},
						new CheckBox()
						{
							Text="Su",
							Tag= new Hizmet(){HizmetAdi="Su",HizmetFiyati=5}
						},
						new CheckBox()
						{
							Text="Soda",
							Tag= new Hizmet(){HizmetAdi="Soda",HizmetFiyati=10}
						},
						new CheckBox()
						{
							Text="İçki",
							Tag= new Hizmet(){HizmetAdi="İçki",HizmetFiyati=100}
						},
						new CheckBox()
						{
							Text="Meyve Suyu",
							Tag= new Hizmet(){HizmetAdi="Meyve Suyu",HizmetFiyati=20}
						},

					}
				);
		}

		double rezarvasyonUcreti = 0;
		Rezervasyon guncellenecekRezervasyon = null;

		//rezervasynlar listesinden guncellenemek istenen rezervasyonun indisini tutar
		int rezarvasyonIndeksi = 0;
		private void RezervasyonuBul()
		{
			for (int i = 0; i < _rezervasyonlar.Count; i++)
			{
				if (cmbMusteriler.SelectedItem == _rezervasyonlar[i].Musteri)
				{
					guncellenecekRezervasyon = _rezervasyonlar[i];
					rezarvasyonIndeksi = i;
					dtpCikisTarihi.Value = _rezervasyonlar[i].CikisTarihi;
				}
			}
		}

		/// <summary>
		/// Müşterinin Çıkış Tarihi Değiştirildiğinde çalışır.
		/// Seçilen müşterinin çıkış tarihine güncellenir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
		{
			rezarvasyonUcreti = (guncellenecekRezervasyon.Oda.Fiyat * (dtpCikisTarihi.Value - guncellenecekRezervasyon.GirisTarihi).TotalDays);

			label4.Text = rezarvasyonUcreti.ToString();
		}

		/// <summary>
		/// Ek hizmetleri ve tarih değişikliğini hesaplayarak ara toplam gösterme
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAraToplam_Click(object sender, EventArgs e)
		{
			foreach (CheckBox checbox in flwHizmetler.Controls)
			{
				if (checbox.Checked)
				{
					Hizmet hizmet = checbox.Tag as Hizmet;
					rezarvasyonUcreti += hizmet.HizmetFiyati * Convert.ToDouble(numEkHizmetAdet.Value);
				}
			}
			label4.Text = rezarvasyonUcreti.ToString();
		}

		/// <summary>
		/// Hesaplamalar tamamlandıktan sonra rezervasyonu kaydet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHesapla_Click(object sender, EventArgs e)
		{
			//combobox boş olamaz
			//şeçilen tarih datetime now dan önce olamaz
			if (Validasyon())
			{
				// guncellenecek rezervasyon bilgilerini güncelle ve listedeki rezervasyon ile değiştir.
				guncellenecekRezervasyon.CikisTarihi = dtpCikisTarihi.Value;
				guncellenecekRezervasyon.RezarvasyonUcreti = rezarvasyonUcreti;
				_rezervasyonlar[rezarvasyonIndeksi] = guncellenecekRezervasyon;

				MessageBox.Show("Rezervasyon Güncellendi");
			}
		}

		private bool Validasyon()
		{
			return (cmbMusteriler.SelectedItem != null) && (dtpCikisTarihi.Value.Date >= DateTime.Now.Date);
		}
	}
}
