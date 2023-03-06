
namespace Otel.UI
{
	partial class FrmOda
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flwKatlar = new System.Windows.Forms.FlowLayoutPanel();
			this.lblOdaBilgileri = new System.Windows.Forms.Label();
			this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
			this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
			this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
			this.btnRezervasyonOlustur = new System.Windows.Forms.Button();
			this.numYas = new System.Windows.Forms.NumericUpDown();
			this.mskdTelefonNo = new System.Windows.Forms.MaskedTextBox();
			this.mskdTcNo = new System.Windows.Forms.MaskedTextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.lblSecilenOda = new System.Windows.Forms.Label();
			this.lblCikisTarihi = new System.Windows.Forms.Label();
			this.lblGirisTarihi = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblYas = new System.Windows.Forms.Label();
			this.lblTelefonNo = new System.Windows.Forms.Label();
			this.lblTCNumarasi = new System.Windows.Forms.Label();
			this.lblSoyad = new System.Windows.Forms.Label();
			this.lblAd = new System.Windows.Forms.Label();
			this.lblOdaninGunlukFiyati = new System.Windows.Forms.Label();
			this.lblGunlukFiyat = new System.Windows.Forms.Label();
			this.grpMusteriBilgileri.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numYas)).BeginInit();
			this.SuspendLayout();
			// 
			// flwKatlar
			// 
			this.flwKatlar.Location = new System.Drawing.Point(57, 68);
			this.flwKatlar.Name = "flwKatlar";
			this.flwKatlar.Size = new System.Drawing.Size(602, 499);
			this.flwKatlar.TabIndex = 0;
			// 
			// lblOdaBilgileri
			// 
			this.lblOdaBilgileri.AutoSize = true;
			this.lblOdaBilgileri.Location = new System.Drawing.Point(54, 48);
			this.lblOdaBilgileri.Name = "lblOdaBilgileri";
			this.lblOdaBilgileri.Size = new System.Drawing.Size(80, 16);
			this.lblOdaBilgileri.TabIndex = 1;
			this.lblOdaBilgileri.Text = "Oda Bilgileri";
			// 
			// grpMusteriBilgileri
			// 
			this.grpMusteriBilgileri.Controls.Add(this.dtpCikisTarihi);
			this.grpMusteriBilgileri.Controls.Add(this.dtpGirisTarihi);
			this.grpMusteriBilgileri.Controls.Add(this.btnRezervasyonOlustur);
			this.grpMusteriBilgileri.Controls.Add(this.numYas);
			this.grpMusteriBilgileri.Controls.Add(this.mskdTelefonNo);
			this.grpMusteriBilgileri.Controls.Add(this.mskdTcNo);
			this.grpMusteriBilgileri.Controls.Add(this.txtSoyad);
			this.grpMusteriBilgileri.Controls.Add(this.txtAd);
			this.grpMusteriBilgileri.Controls.Add(this.lblSecilenOda);
			this.grpMusteriBilgileri.Controls.Add(this.lblCikisTarihi);
			this.grpMusteriBilgileri.Controls.Add(this.lblGirisTarihi);
			this.grpMusteriBilgileri.Controls.Add(this.label7);
			this.grpMusteriBilgileri.Controls.Add(this.lblYas);
			this.grpMusteriBilgileri.Controls.Add(this.lblTelefonNo);
			this.grpMusteriBilgileri.Controls.Add(this.lblTCNumarasi);
			this.grpMusteriBilgileri.Controls.Add(this.lblSoyad);
			this.grpMusteriBilgileri.Controls.Add(this.lblAd);
			this.grpMusteriBilgileri.Location = new System.Drawing.Point(759, 61);
			this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
			this.grpMusteriBilgileri.Size = new System.Drawing.Size(391, 573);
			this.grpMusteriBilgileri.TabIndex = 2;
			this.grpMusteriBilgileri.TabStop = false;
			this.grpMusteriBilgileri.Text = "Musteri Bilgileri";
			// 
			// dtpCikisTarihi
			// 
			this.dtpCikisTarihi.Location = new System.Drawing.Point(161, 427);
			this.dtpCikisTarihi.Name = "dtpCikisTarihi";
			this.dtpCikisTarihi.Size = new System.Drawing.Size(204, 22);
			this.dtpCikisTarihi.TabIndex = 4;
			// 
			// dtpGirisTarihi
			// 
			this.dtpGirisTarihi.Location = new System.Drawing.Point(161, 374);
			this.dtpGirisTarihi.Name = "dtpGirisTarihi";
			this.dtpGirisTarihi.Size = new System.Drawing.Size(204, 22);
			this.dtpGirisTarihi.TabIndex = 4;
			// 
			// btnRezervasyonOlustur
			// 
			this.btnRezervasyonOlustur.Location = new System.Drawing.Point(30, 493);
			this.btnRezervasyonOlustur.Name = "btnRezervasyonOlustur";
			this.btnRezervasyonOlustur.Size = new System.Drawing.Size(335, 48);
			this.btnRezervasyonOlustur.TabIndex = 3;
			this.btnRezervasyonOlustur.Text = "Rezervasyon Oluştur";
			this.btnRezervasyonOlustur.UseVisualStyleBackColor = true;
			this.btnRezervasyonOlustur.Click += new System.EventHandler(this.btnRezervasyonOlustur_Click);
			// 
			// numYas
			// 
			this.numYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numYas.Location = new System.Drawing.Point(161, 264);
			this.numYas.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.numYas.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
			this.numYas.Name = "numYas";
			this.numYas.Size = new System.Drawing.Size(204, 28);
			this.numYas.TabIndex = 3;
			this.numYas.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			// 
			// mskdTelefonNo
			// 
			this.mskdTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskdTelefonNo.Location = new System.Drawing.Point(161, 211);
			this.mskdTelefonNo.Mask = "500-000-00-00";
			this.mskdTelefonNo.Name = "mskdTelefonNo";
			this.mskdTelefonNo.Size = new System.Drawing.Size(204, 28);
			this.mskdTelefonNo.TabIndex = 2;
			// 
			// mskdTcNo
			// 
			this.mskdTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskdTcNo.Location = new System.Drawing.Point(161, 159);
			this.mskdTcNo.Mask = "00000000000";
			this.mskdTcNo.Name = "mskdTcNo";
			this.mskdTcNo.Size = new System.Drawing.Size(204, 28);
			this.mskdTcNo.TabIndex = 2;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyad.Location = new System.Drawing.Point(161, 101);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(204, 27);
			this.txtSoyad.TabIndex = 1;
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(161, 53);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(204, 27);
			this.txtAd.TabIndex = 1;
			// 
			// lblSecilenOda
			// 
			this.lblSecilenOda.AutoSize = true;
			this.lblSecilenOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSecilenOda.Location = new System.Drawing.Point(157, 316);
			this.lblSecilenOda.Name = "lblSecilenOda";
			this.lblSecilenOda.Size = new System.Drawing.Size(43, 22);
			this.lblSecilenOda.TabIndex = 0;
			this.lblSecilenOda.Text = "000";
			// 
			// lblCikisTarihi
			// 
			this.lblCikisTarihi.AutoSize = true;
			this.lblCikisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCikisTarihi.Location = new System.Drawing.Point(26, 427);
			this.lblCikisTarihi.Name = "lblCikisTarihi";
			this.lblCikisTarihi.Size = new System.Drawing.Size(111, 24);
			this.lblCikisTarihi.TabIndex = 0;
			this.lblCikisTarihi.Text = "Çıkış Tarihi: ";
			// 
			// lblGirisTarihi
			// 
			this.lblGirisTarihi.AutoSize = true;
			this.lblGirisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGirisTarihi.Location = new System.Drawing.Point(26, 374);
			this.lblGirisTarihi.Name = "lblGirisTarihi";
			this.lblGirisTarihi.Size = new System.Drawing.Size(101, 24);
			this.lblGirisTarihi.TabIndex = 0;
			this.lblGirisTarihi.Text = "Giriş tarihi: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(26, 316);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 24);
			this.label7.TabIndex = 0;
			this.label7.Text = "Şeçilen Oda:";
			// 
			// lblYas
			// 
			this.lblYas.AutoSize = true;
			this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblYas.Location = new System.Drawing.Point(26, 268);
			this.lblYas.Name = "lblYas";
			this.lblYas.Size = new System.Drawing.Size(79, 24);
			this.lblYas.TabIndex = 0;
			this.lblYas.Text = "Yaşınız: ";
			// 
			// lblTelefonNo
			// 
			this.lblTelefonNo.AutoSize = true;
			this.lblTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTelefonNo.Location = new System.Drawing.Point(26, 215);
			this.lblTelefonNo.Name = "lblTelefonNo";
			this.lblTelefonNo.Size = new System.Drawing.Size(114, 24);
			this.lblTelefonNo.TabIndex = 0;
			this.lblTelefonNo.Text = "Telefon No: ";
			// 
			// lblTCNumarasi
			// 
			this.lblTCNumarasi.AutoSize = true;
			this.lblTCNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTCNumarasi.Location = new System.Drawing.Point(26, 157);
			this.lblTCNumarasi.Name = "lblTCNumarasi";
			this.lblTCNumarasi.Size = new System.Drawing.Size(75, 24);
			this.lblTCNumarasi.TabIndex = 0;
			this.lblTCNumarasi.Text = "TC No: ";
			// 
			// lblSoyad
			// 
			this.lblSoyad.AutoSize = true;
			this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSoyad.Location = new System.Drawing.Point(26, 104);
			this.lblSoyad.Name = "lblSoyad";
			this.lblSoyad.Size = new System.Drawing.Size(73, 24);
			this.lblSoyad.TabIndex = 0;
			this.lblSoyad.Text = "Soyad: ";
			// 
			// lblAd
			// 
			this.lblAd.AutoSize = true;
			this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAd.Location = new System.Drawing.Point(26, 53);
			this.lblAd.Name = "lblAd";
			this.lblAd.Size = new System.Drawing.Size(44, 24);
			this.lblAd.TabIndex = 0;
			this.lblAd.Text = "Ad: ";
			// 
			// lblOdaninGunlukFiyati
			// 
			this.lblOdaninGunlukFiyati.AutoSize = true;
			this.lblOdaninGunlukFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOdaninGunlukFiyati.Location = new System.Drawing.Point(54, 592);
			this.lblOdaninGunlukFiyati.Name = "lblOdaninGunlukFiyati";
			this.lblOdaninGunlukFiyati.Size = new System.Drawing.Size(231, 22);
			this.lblOdaninGunlukFiyati.TabIndex = 0;
			this.lblOdaninGunlukFiyati.Text = "Odanın Günlük Fiyat Bilgisi:";
			// 
			// lblGunlukFiyat
			// 
			this.lblGunlukFiyat.AutoSize = true;
			this.lblGunlukFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGunlukFiyat.Location = new System.Drawing.Point(324, 592);
			this.lblGunlukFiyat.Name = "lblGunlukFiyat";
			this.lblGunlukFiyat.Size = new System.Drawing.Size(20, 22);
			this.lblGunlukFiyat.TabIndex = 3;
			this.lblGunlukFiyat.Text = "0";
			// 
			// FrmOda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1181, 647);
			this.Controls.Add(this.lblGunlukFiyat);
			this.Controls.Add(this.lblOdaninGunlukFiyati);
			this.Controls.Add(this.grpMusteriBilgileri);
			this.Controls.Add(this.lblOdaBilgileri);
			this.Controls.Add(this.flwKatlar);
			this.Name = "FrmOda";
			this.Text = "FrmOda";
			this.Load += new System.EventHandler(this.FrmOda_Load);
			this.grpMusteriBilgileri.ResumeLayout(false);
			this.grpMusteriBilgileri.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numYas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flwKatlar;
		private System.Windows.Forms.Label lblOdaBilgileri;
		private System.Windows.Forms.GroupBox grpMusteriBilgileri;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label lblTelefonNo;
		private System.Windows.Forms.Label lblTCNumarasi;
		private System.Windows.Forms.Label lblSoyad;
		private System.Windows.Forms.Label lblAd;
		private System.Windows.Forms.Button btnRezervasyonOlustur;
		private System.Windows.Forms.NumericUpDown numYas;
		private System.Windows.Forms.MaskedTextBox mskdTelefonNo;
		private System.Windows.Forms.MaskedTextBox mskdTcNo;
		private System.Windows.Forms.Label lblYas;
		private System.Windows.Forms.Label lblSecilenOda;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblOdaninGunlukFiyati;
		private System.Windows.Forms.Label lblGunlukFiyat;
		private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
		private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
		private System.Windows.Forms.Label lblCikisTarihi;
		private System.Windows.Forms.Label lblGirisTarihi;
	}
}