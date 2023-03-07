using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class DuzbucagliP : FezaFiqurlari
	{
		private double a;
		private double b;
		private double c;
		public DuzbucagliP(double a, double b, double c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}

		public override double s_oturacaq()
		{
			
			return 0;
		}

		public override double s_tam()
		{
			double sTam = 2*(a * b + c * a + b * c);
			return sTam;
		}

		public override double v()
		{
			double hecm = a * b * c;
			return hecm;
		}
	}
}
