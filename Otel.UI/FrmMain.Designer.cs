
namespace Otel.UI
{
	partial class FrmMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.odaGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.faturalandırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odalarToolStripMenuItem,
            this.faturalandırmaToolStripMenuItem,
            this.raporToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1236, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// odalarToolStripMenuItem
			// 
			this.odalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaGuncelleToolStripMenuItem});
			this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
			this.odalarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
			this.odalarToolStripMenuItem.Text = "Odalar";
			// 
			// odaGuncelleToolStripMenuItem
			// 
			this.odaGuncelleToolStripMenuItem.Name = "odaGuncelleToolStripMenuItem";
			this.odaGuncelleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.odaGuncelleToolStripMenuItem.Text = "Oda Guncelle";
			// 
			// faturalandırmaToolStripMenuItem
			// 
			this.faturalandırmaToolStripMenuItem.Name = "faturalandırmaToolStripMenuItem";
			this.faturalandırmaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
			this.faturalandırmaToolStripMenuItem.Text = "Faturalandırma";
			this.faturalandırmaToolStripMenuItem.Click += new System.EventHandler(this.faturalandirmaToolStripMenuItem_Click);
			// 
			// raporToolStripMenuItem
			// 
			this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
			this.raporToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
			this.raporToolStripMenuItem.Text = "Rapor";
			this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 755);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem faturalandırmaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem odaGuncelleToolStripMenuItem;
	}
}