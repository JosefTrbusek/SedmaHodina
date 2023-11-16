namespace Dedeni
{
    public class Slepice : Zvire
    {
        public int Nosnost;
        public int Snuska;
        public Slepice(string jmeno, int nosnost) : base(jmeno, 50, 5)
        {
            Nosnost = nosnost;
            Snuska = 0;
        }

        public string SnesVejce()
        {
            Snuska++;
            return "Kdak";
        }
    }
}
