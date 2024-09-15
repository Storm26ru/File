#include<iostream>
#include<fstream>
#include<string>
using namespace std;



void main()
{
	setlocale(LC_ALL, "");
	fstream fin("201 RAW.txt");
	ofstream fout("201 ready.txt",ios_base::app);
	ofstream fout1("201.dncpd.txt", ios_base::app);
	if (fin.is_open())
	{
		int count = 0;
		while (!fin.eof())
		{
			string buffer1;
			string buffer2;
			fin >> buffer1;
			fin >> buffer2;
			fout << buffer2 << "\t" << buffer1 << endl;
			fout1 << "host-" << ++count<< "\n\n{\n\n\thardware ethernet\t" << buffer2 << ";\n\n\tfixed-address\t\t" << buffer1 << ";\n\n}\n\n" << endl;
		}
		fin.close();
		fout.close();
		fout1.close();
	}
	else std::cerr << "Error: file not found" << endl;
	system("notepad 201 ready.txt");
	system("notepad 201.dncpd.txt");
	
	


}