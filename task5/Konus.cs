using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class Konus : FezaFiqurlari
	{
		private double h;
		public Konus(double radius,double hundurluk)
		{
			this.h = hundurluk;
			this.r= radius;
		}
		public override double s_oturacaq()
		{
			double s = pi * r * r;
			return s;
		}

		public override double s_tam()
		{
			return 0;
		}

		public override double v()
		{
			double hecm = pi * r * r * (h / 3);
			return hecm;
		}
	}
}
