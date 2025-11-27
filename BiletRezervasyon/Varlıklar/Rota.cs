namespace BiletRezervasyon.Varlıklar
{
    public class Rota
    {
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }

        public Rota(string kalkisYeri , string varisYeri)
        {
            KalkisYeri = kalkisYeri;
            VarisYeri = varisYeri;

        }

        public override string ToString()
        {
            return $"{KalkisYeri} -> {VarisYeri}";
        }
    }
}
