using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCS
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
			    StreamReader sr = new StreamReader("201 RAW.txt");
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine().Split(' ').Last();
					Console.WriteLine(buffer);
				}
				sr.Close();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
