
namespace Otel.UI
{
	partial class FrmRapor
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
			this.label1 = new System.Windows.Forms.Label();
			this.lstRapor = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnFitrele = new System.Windows.Forms.Button();
			this.txtArancakKelime = new System.Windows.Forms.TextBox();
			this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
			this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnTarihFiltrele = new System.Windows.Forms.Button();
			this.btnTumListe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(22, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Müşteri Seçiniz: ";
			// 
			// lstRapor
			// 
			this.lstRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.lstRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstRapor.HideSelection = false;
			this.lstRapor.Location = new System.Drawing.Point(0, 220);
			this.lstRapor.Name = "lstRapor";
			this.lstRapor.Size = new System.Drawing.Size(1141, 458);
			this.lstRapor.TabIndex = 2;
			this.lstRapor.UseCompatibleStateImageBehavior = false;
			this.lstRapor.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Sıra No";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Kat No";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Oda No";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Odanın Durumu";
			this.columnHeader4.Width = 120;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Musteri Ad Soyad";
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "TC No";
			this.columnHeader6.Width = 120;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Telefon No";
			this.columnHeader7.Width = 120;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Giris Tarihi";
			this.columnHeader8.Width = 150;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Çıkış Tarihi";
			this.columnHeader9.Width = 150;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Rezarvasyon Ücreti";
			this.columnHeader10.Width = 150;
			// 
			// btnFitrele
			// 
			this.btnFitrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFitrele.Location = new System.Drawing.Point(253, 89);
			this.btnFitrele.Name = "btnFitrele";
			this.btnFitrele.Size = new System.Drawing.Size(215, 48);
			this.btnFitrele.TabIndex = 3;
			this.btnFitrele.Text = "Filtrele";
			this.btnFitrele.UseVisualStyleBackColor = true;
			this.btnFitrele.Click += new System.EventHandler(this.btnFitrele_Click);
			// 
			// txtArancakKelime
			// 
			this.txtArancakKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtArancakKelime.Location = new System.Drawing.Point(213, 40);
			this.txtArancakKelime.Name = "txtArancakKelime";
			this.txtArancakKelime.Size = new System.Drawing.Size(287, 28);
			this.txtArancakKelime.TabIndex = 4;
			// 
			// dtpGirisTarihi
			// 
			this.dtpGirisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpGirisTarihi.Location = new System.Drawing.Point(830, 34);
			this.dtpGirisTarihi.Name = "dtpGirisTarihi";
			this.dtpGirisTarihi.Size = new System.Drawing.Size(287, 27);
			this.dtpGirisTarihi.TabIndex = 5;
			// 
			// dtpCikisTarihi
			// 
			this.dtpCikisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpCikisTarihi.Location = new System.Drawing.Point(830, 89);
			this.dtpCikisTarihi.Name = "dtpCikisTarihi";
			this.dtpCikisTarihi.Size = new System.Drawing.Size(287, 27);
			this.dtpCikisTarihi.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(635, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Giriş Tarihi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(635, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Çıkış Tarhi";
			// 
			// btnTarihFiltrele
			// 
			this.btnTarihFiltrele.Location = new System.Drawing.Point(830, 141);
			this.btnTarihFiltrele.Name = "btnTarihFiltrele";
			this.btnTarihFiltrele.Size = new System.Drawing.Size(287, 40);
			this.btnTarihFiltrele.TabIndex = 6;
			this.btnTarihFiltrele.Text = "Tarihe Göre Filtrele";
			this.btnTarihFiltrele.UseVisualStyleBackColor = true;
			this.btnTarihFiltrele.Click += new System.EventHandler(this.btnTarihFiltrele_Click);
			// 
			// btnTumListe
			// 
			this.btnTumListe.Location = new System.Drawing.Point(12, 180);
			this.btnTumListe.Name = "btnTumListe";
			this.btnTumListe.Size = new System.Drawing.Size(105, 33);
			this.btnTumListe.TabIndex = 7;
			this.btnTumListe.Text = "Tüm Liste";
			this.btnTumListe.UseVisualStyleBackColor = true;
			this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
			// 
			// FrmRapor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1141, 678);
			this.Controls.Add(this.btnTumListe);
			this.Controls.Add(this.btnTarihFiltrele);
			this.Controls.Add(this.dtpCikisTarihi);
			this.Controls.Add(this.dtpGirisTarihi);
			this.Controls.Add(this.txtArancakKelime);
			this.Controls.Add(this.btnFitrele);
			this.Controls.Add(this.lstRapor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmRapor";
			this.Text = "FrmRapor";
			this.Load += new System.EventHandler(this.FrmRapor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lstRapor;
		private System.Windows.Forms.Button btnFitrele;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.TextBox txtArancakKelime;
		private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
		private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnTarihFiltrele;
		private System.Windows.Forms.Button btnTumListe;
	}
}