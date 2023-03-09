using System.Transactions;
using System.Xml.Linq;

namespace task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var s = new Silndr(4,2);
			Console.WriteLine(s);
			var d = new DuzbucagliP(2, 4, 6);
			Console.WriteLine(d);
			var k = new Konus(3, 5);
			Console.WriteLine(k);
			Console.WriteLine("salam");

		}
	}
}