namespace BiletRezervasyon.Varlıklar
{
    public class Ucak
    {
        public int UcakID { get; set; }
        public string Model { get; set; }
        public int Kapasite { get; set; }
        public string KuyrukNo { get; set; }

        public override string ToString()
        {
            return KuyrukNo;
        }
    }
}