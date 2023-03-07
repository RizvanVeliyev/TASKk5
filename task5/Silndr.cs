using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class Silndr : FezaFiqurlari
	{
		private double l;
		public Silndr(double radius,double uzunluq)
		{
			this.r = radius;
			this.l=uzunluq;


		}
		public override double s_oturacaq()
		{
			 double s = pi * r *r;
			return s;
		}

		public override double s_tam()
		{
			double s_tam = 2 * pi * r * r * 2 * pi * r * l;
			return s_tam;
		}

		public override double v()
		{
			double hecm = pi * r * r * l;
			return hecm;
		}
		
	}
}
