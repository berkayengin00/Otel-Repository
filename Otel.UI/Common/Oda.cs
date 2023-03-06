using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.UI.Common
{
	public class Oda
	{
		public byte OdaNumarasi { get; set; }
		public byte KatNumarasi { get; set; }
		public double Fiyat { get; set; }
		public byte YatakSayisi { get; set; }
		public OdaDurumu OdaDurumu { get; set; }
	}
}
