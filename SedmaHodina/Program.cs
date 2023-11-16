Console.WriteLine("Zadej text");
string text = Console.ReadLine();
Console.WriteLine("Počet znaků: " + text.Count());
Console.WriteLine("Počet bilych znaků: " + text.Count(x => char.IsWhiteSpace(x)));
Console.WriteLine("Převracený text:" + new String(text.Reverse().ToArray()));
var znaky = text.ToUpper().GroupBy(x => x);
znaky = znaky.OrderBy(x => x.Key);
foreach(var znak in znaky)
{
    Console.WriteLine(znak.Key + ": " + znak.Count());
}

var podtext = text.SkipWhile(x => x != 'o').TakeWhile(x => x != 'e');
Console.WriteLine(new String(podtext.ToArray()));
Console.ReadLine();