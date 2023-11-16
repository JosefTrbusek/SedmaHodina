using Dedeni;

List<Zvire> farma = new List<Zvire>();
Krava jitkaKrava = new Krava("Jitka", 100, 1);
farma.Add(jitkaKrava);

Slepice slepice = new Slepice("Bool", 10);
farma.Add(slepice);

foreach(var zvire in farma)
{
    Console.WriteLine(zvire.Jmeno + " važí " + zvire.Vaha + " kg");
    if(zvire is Slepice)
    {
        Console.WriteLine(((Slepice)zvire).SnesVejce());
    }
    if(zvire is Krava)
    {
        Krava krava=(Krava)zvire;
        Console.WriteLine("Dojím " + krava.DejMleko() + " l");
        Console.WriteLine("Dojivost je " + krava.Dojivost);
    }
}

Console.ReadLine();