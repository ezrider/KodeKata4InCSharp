using System.Text.RegularExpressions;
using System.Collections;


//the purpose of this script:
//Part One: Weather Data
//Download this text file, then write a program to output the day number (column one) with the smallest temperature spread (the maximum temperature is the second column, the minimum the third column).
//ie find what day has the smallest temperature spread.

//Decisions: what to do with the last data line since the day number is not correct.


string startupPath = Environment.CurrentDirectory;
Console.WriteLine("currennt directory {0}", startupPath);

Hashtable hashtable = new Hashtable();
int j = 0;
int dayIndex = 0;
int maxTempIndex = 1;
int minTempIndex = 2;
var maxTemp = 0;
var minTemp = 0;
var filePath = startupPath  + "\\..\\Data\\weather.dat";
string[] lines = System.IO.File.ReadAllLines(filePath);
List<string> newlines = new List<string>(lines);
Console.WriteLine("bla");

newlines.RemoveAt(0); // get rid of headers for now

int count = 0;
foreach (string line in lines)
{
	if (lines[count].Length == 0)
	{
		Console.WriteLine("Removing line {0}: {1}", count, line);
		newlines.RemoveAt(count);
		//Console.WriteLine("line length is {0} and {1}", line.Length, lines[count].Length);
		count = count + 1;
		continue;
	}
	
	//string[] linewords = Regex.Split(line, @"\W+");
	//if ((Int32.TryParse(linewords[0],out j) != true) or (Int32.TryParse(linewords[1]) != true or (Int32.TryParse(linewords[2]) != true) 
	//{
	//	newlines.RemoveAt(count);
	//}
	
	
	count = count + 1;
	
}


foreach (string line in newlines)
{
	
	string[] linewords = Regex.Split(line.TrimStart(), @"\W+");
	if (linewords.Length <4 ){continue;}
	//Console.WriteLine("do it {0}",linewords.Length);
	if (Int32.TryParse(linewords[0], out j) != true	|| Int32.TryParse(linewords[1], out j) != true || Int32.TryParse(linewords[2], out j) != true) { Console.WriteLine("Found bad data");continue;}
	maxTemp = Convert.ToInt32(linewords[maxTempIndex]);
	minTemp = Convert.ToInt32(linewords[minTempIndex]);
	int tempSpread = maxTemp - minTemp;
	Console.WriteLine(" maxTemp is {0} and minTemp is {1} with a spread of {2}",maxTemp, minTemp, tempSpread);
	var day = linewords[0];
	bool smallest = false;
	bool equalto = false;
	foreach (int spread in hashtable.Values)
	{
		if (tempSpread < spread) { smallest = true ;}
		else if (tempSpread == spread) {equalto = true;}
		
	}
	if (hashtable.Count == 0) 
	{ hashtable.Add(day,tempSpread);
	}
	else
	{
		if (equalto) { hashtable.Add(day,tempSpread);}
		if (smallest) { hashtable.Clear(); hashtable.Add(day,tempSpread);}
	}
	
}

foreach (string key in hashtable.Keys)
{
		Console.WriteLine("The day {0} had the smallest spread of {1}", key,hashtable[key]);
}