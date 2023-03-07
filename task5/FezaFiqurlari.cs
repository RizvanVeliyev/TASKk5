using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public abstract class FezaFiqurlari
	{
		protected double pi=3;
		protected double r;
		
		public abstract double v();
		public abstract double s_oturacaq();

		public abstract double s_tam();

		public override string ToString()
		{
			return $@"fiqurun adi:{this.GetType().Name}
sTam={this.s_tam()}
s_oturacag={this.s_oturacaq()}
hecm={this.v()}";
		}

	}
}
