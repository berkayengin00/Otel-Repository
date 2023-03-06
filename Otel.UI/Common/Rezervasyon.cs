using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.UI.Common
{
	public class Rezervasyon
	{
		public Musteri Musteri { get; set; }
		public Oda Oda { get; set; }
		public DateTime GirisTarihi { get; set; }
		public DateTime CikisTarihi { get; set; }
		public double RezarvasyonUcreti { get; set; }
	}
}
