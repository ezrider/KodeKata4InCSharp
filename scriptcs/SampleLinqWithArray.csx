var filename = "some file.csv"
var lines = File.ReadAllLines(filename).Select(a=>a.Split(','));
var first10 = lines.Select(l=> l[1]).Skip(1).OrderBy(l => l).Take(10);
Console.WriteLine(String.Join("\n".first10);