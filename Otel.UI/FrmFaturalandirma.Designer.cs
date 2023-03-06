
namespace Otel.UI
{
	partial class FrmFaturalandirma
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
			this.cmbMusteriler = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.flwHizmetler = new System.Windows.Forms.FlowLayoutPanel();
			this.numEkHizmetAdet = new System.Windows.Forms.NumericUpDown();
			this.btnAraToplam = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnHesapla = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numEkHizmetAdet)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbMusteriler
			// 
			this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbMusteriler.FormattingEnabled = true;
			this.cmbMusteriler.Location = new System.Drawing.Point(251, 44);
			this.cmbMusteriler.Name = "cmbMusteriler";
			this.cmbMusteriler.Size = new System.Drawing.Size(403, 28);
			this.cmbMusteriler.TabIndex = 0;
			this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriler_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(30, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Musteri Seçiniz: ";
			// 
			// dtpCikisTarihi
			// 
			this.dtpCikisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpCikisTarihi.Location = new System.Drawing.Point(251, 110);
			this.dtpCikisTarihi.Name = "dtpCikisTarihi";
			this.dtpCikisTarihi.Size = new System.Drawing.Size(403, 27);
			this.dtpCikisTarihi.TabIndex = 2;
			this.dtpCikisTarihi.ValueChanged += new System.EventHandler(this.dtpCikisTarihi_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(30, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Çıkış Tarihini Güncelle:";
			// 
			// flwHizmetler
			// 
			this.flwHizmetler.Location = new System.Drawing.Point(34, 190);
			this.flwHizmetler.Name = "flwHizmetler";
			this.flwHizmetler.Size = new System.Drawing.Size(620, 84);
			this.flwHizmetler.TabIndex = 3;
			// 
			// numEkHizmetAdet
			// 
			this.numEkHizmetAdet.Location = new System.Drawing.Point(205, 298);
			this.numEkHizmetAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numEkHizmetAdet.Name = "numEkHizmetAdet";
			this.numEkHizmetAdet.Size = new System.Drawing.Size(99, 22);
			this.numEkHizmetAdet.TabIndex = 4;
			this.numEkHizmetAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAraToplam
			// 
			this.btnAraToplam.Location = new System.Drawing.Point(344, 298);
			this.btnAraToplam.Name = "btnAraToplam";
			this.btnAraToplam.Size = new System.Drawing.Size(80, 25);
			this.btnAraToplam.TabIndex = 5;
			this.btnAraToplam.Text = "+";
			this.btnAraToplam.UseVisualStyleBackColor = true;
			this.btnAraToplam.Click += new System.EventHandler(this.btnAraToplam_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(471, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Toplam Fiyat: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(605, 299);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Ek hizmetler";
			// 
			// btnHesapla
			// 
			this.btnHesapla.Location = new System.Drawing.Point(227, 371);
			this.btnHesapla.Name = "btnHesapla";
			this.btnHesapla.Size = new System.Drawing.Size(197, 46);
			this.btnHesapla.TabIndex = 9;
			this.btnHesapla.Text = "Rezervasyonu Guncelle";
			this.btnHesapla.UseVisualStyleBackColor = true;
			this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 300);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(151, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Ek Hizmet Adedi Giriniz: ";
			// 
			// FrmFaturalandirma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 445);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnHesapla);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAraToplam);
			this.Controls.Add(this.numEkHizmetAdet);
			this.Controls.Add(this.flwHizmetler);
			this.Controls.Add(this.dtpCikisTarihi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMusteriler);
			this.Name = "FrmFaturalandirma";
			this.Text = "FrmFaturalandırma";
			this.Load += new System.EventHandler(this.FrmFaturalandirma_Load);
			((System.ComponentModel.ISupportInitialize)(this.numEkHizmetAdet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbMusteriler;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flwHizmetler;
		private System.Windows.Forms.NumericUpDown numEkHizmetAdet;
		private System.Windows.Forms.Button btnAraToplam;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnHesapla;
		private System.Windows.Forms.Label label6;
	}
}