namespace BiletRezervasyon.Varlıklar
{
    internal class Rota
    {
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }

        public override string ToString()
        {
            return $"{KalkisYeri} -> {VarisYeri}";
        }
    }
}
