namespace Dedeni
{
    public class Zvire
    {
        public double Vaha;
        public double Vyska;
        public string Jmeno;
        public Zvire(string jmeno, double vyska, double vaha)
        {
            Jmeno= jmeno;
            Vyska= vyska;
            Vaha= vaha;
        }

        public string Zer()
        {
            Vaha++;
            return "Nam Nam";
        }
    }
}
