using System;
using System.Windows.Forms;

namespace Otel.UI
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}
		FrmOda frmOda = null;
		private void FrmMain_Load(object sender, EventArgs e)
		{
			frmOda = new FrmOda();
			frmOda.MdiParent = this;
			frmOda.Show();
		}
		FrmFaturalandirma frmFaturalandırma=null;
		private void faturalandirmaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			//eğer rezarvosyon yapıldıysa girer
			if (frmOda.rezervasyonlar.Count > 0)
			{
				frmFaturalandırma = new FrmFaturalandirma();
				frmFaturalandırma._rezervasyonlar = frmOda.rezervasyonlar;
				frmFaturalandırma.MdiParent = this;
				frmFaturalandırma.Show();
			}
			else
			{
				MessageBox.Show("Kimse Rezarvasyon Yapmadı");
			}
			
		}

		private void raporToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frmOda.rezervasyonlar.Count>0&&frmFaturalandırma._rezervasyonlar!=null)
			{
				frmOda.Close();
				FrmRapor frmRapor = new FrmRapor();
				frmRapor._rezervasyonlar = frmFaturalandırma._rezervasyonlar;
				frmRapor.MdiParent = this;
				frmRapor.Show();
			}
			else
			{
				MessageBox.Show("Kimse Rezarvasyon Yapmadı");
			}			
		}
	}
}
