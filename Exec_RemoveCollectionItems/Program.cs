using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items1 = new List<int>() { 3, 8, 6, 7, 5 };

			items1.RemoveRange(2, 3);
			foreach (var item in items1)
			{
				Console.WriteLine(item); //print 3 8
			}
		}
	}
}
