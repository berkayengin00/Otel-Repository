using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.UI.Common
{
	public class Musteri
	{
		public string MusteriAdi { get; set; }
		public string MusteriSoyadi { get; set; }
		public string TcNumarasi { get; set; }
		public string TelefonNumarasi { get; set; }
		public override string ToString()
		{
			return MusteriAdi +" " + MusteriSoyadi+ " - " + TcNumarasi;
		}
	}
}
