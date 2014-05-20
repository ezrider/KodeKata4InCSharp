#r "Microsoft.VisualBasic"
using Microsoft.VisualBasic.FileIO;

string startupPath = Environment.CurrentDirectory;
//var filePath = startupPath  + "\\..\\Data\\simple.csv";
var filePath = startupPath  + "\\..\\Data\\weather.dat";


using(TextFieldParser parser = new TextFieldParser(filePath))
{
	while (true)
	{
		parser.TextFieldType = FieldType.FixedWidth;
		//				Dy MxT   MnT   AvT   HDDay  AvDP 1HrP TPcpn WxType PDir AvSp Dir MxS SkyC MxR MnR AvSLP

		//int[] fields = { 4,5,	 5,    6,     6,     6,    5,  6,     6,     5,  4,   4,   5,   4,  4,  4,  6 };
		int[] fields = { 4,6, 6, 6,  6, 6, 5, 6, 6,  7, 5, 4,  5,  4,  4,  4, 6 };
		parser.SetFieldWidths(fields);
		//string[] currentRow = new string[8];

		string[] parts = parser.ReadFields();
		if (parts == null)
		{
			break;
		}
		Console.WriteLine({0} field(s)", parts.Length);
	}

}

