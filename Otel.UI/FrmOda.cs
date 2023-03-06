using Otel.UI.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Otel.UI.Validation.ValidationTool;

namespace Otel.UI
{
	public partial class FrmOda : Form
	{
		public FrmOda()
		{
			InitializeComponent();
		}

		private void FrmOda_Load(object sender, EventArgs e)
		{
			//oda bilgilerini içeren butonlar oluşturuluyor
			ButonlariOlustur();
			grpMusteriBilgileri.Enabled = false;
		}

		private void ButonlariOlustur()
		{
			byte sayac = 100;
			for (byte i = 1; i <= 3; i++)
			{
				Label label = new Label();
				label.Text = string.Format("{0}. Kat ( {1} Kişilik)", i, i);
				flwKatlar.Controls.Add(label);
				flwKatlar.SetFlowBreak(label, true);
				for (byte j = 1; j <= 10; j++)
				{
					Button button = new Button();
					button.Text = (++sayac).ToString();
					button.BackColor = Color.Green;
					button.Width = 80;
					button.Height = 30;
					button.Tag = new Oda()
					{
						KatNumarasi = i,
						YatakSayisi = i,
						Fiyat = i * 50,
						OdaNumarasi = (sayac),
						OdaDurumu = OdaDurumu.bos
					};
					button.Click += Button_Click;
					flwKatlar.Controls.Add(button);
				}
			}
			KralDairesiOlustur();

		}

		private void KralDairesiOlustur()
		{
			Label label = new Label();
			label.Text = "4. Kat (5 Kişilik)";
			flwKatlar.Controls.Add(label);
			flwKatlar.SetFlowBreak(label, true);
			Button button = new Button();
			button.Text = (200).ToString();
			button.BackColor = Color.Green;
			button.Width = 80;
			button.Height = 30;
			button.Tag = new Oda()
			{
				KatNumarasi = 4,
				YatakSayisi = 5,
				Fiyat = 800,
				OdaNumarasi = 200,
			};
			button.Click += Button_Click;
			flwKatlar.Controls.Add(button);
		}


		//faturalandırma ve rapor için rezervasyonları tutan liste
		public List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
		Button secilenButon = null;
		private Oda secilenOda = null;
		private void Button_Click(object sender, EventArgs e)
		{
			secilenButon = sender as Button;
			secilenOda = secilenButon.Tag as Oda;
			lblSecilenOda.Text = secilenButon.Text;
			lblGunlukFiyat.Text = secilenOda.Fiyat.ToString();
			grpMusteriBilgileri.Enabled = true;
		}

		double rezarvasyonUcreti = 0;
		Rezervasyon rezervasyon = null;
		private void btnRezervasyonOlustur_Click(object sender, EventArgs e)
		{			
			if (Validasyon())
			{
				//Rezervasyon ucretini hesapla 
				rezarvasyonUcreti = secilenOda.Fiyat * (dtpCikisTarihi.Value.Date - dtpGirisTarihi.Value.Date).Days;
				
				DialogResult dialogResult = MessageBox.Show($"Sayın {txtAd.Text} {txtSoyad.Text} " +
					$"\n {dtpGirisTarihi.Value} -  {dtpCikisTarihi.Value} Tarihleri arasında " +
					$"\n {rezarvasyonUcreti} ₺ Tutarındaki işlemi onaylıyor musunuz?",
					"Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				//eğer müşteri yese tıklarsa bilgileri al rezervasyonlara ekle
				if (dialogResult == DialogResult.Yes)
				{
					rezervasyon = new Rezervasyon();
					rezervasyon.Musteri = new Musteri()
					{
						MusteriAdi = txtAd.Text.ToLower(),
						MusteriSoyadi = txtSoyad.Text.ToLower(),
						TcNumarasi = mskdTcNo.Text,
						TelefonNumarasi = mskdTelefonNo.Text
					};
					secilenOda.OdaDurumu = OdaDurumu.dolu;
					rezervasyon.Oda = secilenOda;
					rezervasyon.GirisTarihi = dtpGirisTarihi.Value;
					rezervasyon.CikisTarihi = dtpCikisTarihi.Value;
					rezervasyon.RezarvasyonUcreti = rezarvasyonUcreti;

					rezervasyonlar.Add(rezervasyon);
					
					FormuTemizle();
				}
				else
				{
					MessageBox.Show("Rezarvasyon İptal Edildi");
				}
			}
			else
			{
				MessageBox.Show("Lütfen Giriş Bilgilerinizi Kontrol ediniz!!!");
			}

		}

		private void FormuTemizle()
		{
			//yeni rezervasyon için
			rezervasyon = null;
			lblGunlukFiyat.Text = "";
			lblSecilenOda.Text = "";

			//Oda eklenndikten sonra butonu pasifleştir
			secilenButon.BackColor = Color.Red;
			secilenButon.Enabled = false;
			secilenButon = null;
			//ValidationTool.ResetAllControls(this);

			grpMusteriBilgileri.Enabled = false;
		}

		private bool Validasyon()
		{
			return secilenButon!=null 
				&& BosMu(txtAd.Text, txtSoyad.Text, numYas.Value.ToString(), mskdTcNo.Text, mskdTelefonNo.Text)
				&& SayiVarMi(txtAd.Text, txtSoyad.Text) 
				&& TelefonNoKontrol(mskdTelefonNo.Text) 
				&& TcKontrol(mskdTcNo.Text.ToString()) 
				&& TarihKontrol();
		}

		/// <summary>
		/// Çıkış tarihi, bügünün tarihinden ve Giriş tarihinden büyük ise true döner değilse false döner
		/// </summary>
		/// <returns></returns>
		private bool TarihKontrol()
		{
			// Çıkış tarihi, giriş tarihinden ve bugünden sonraki bir tarih olmalıdır  
			return (dtpGirisTarihi.Value.Date >= DateTime.Now.Date)
				&& (dtpCikisTarihi.Value > dtpGirisTarihi.Value);
		}
	}
}
