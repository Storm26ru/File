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
				StreamWriter sw = new StreamWriter("201 ready.txt",true);
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					if (buffer.Length != 0) sw.WriteLine($"{buffer.Split(' ').Last()}\t{buffer.Substring(0, buffer.IndexOf(' '))}");
					else sw.WriteLine("\n");
				}
				sr.Close();
				sw.Close();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			System.Diagnostics.Process.Start("notepad", "201 ready.txt");
		}
	}
}
