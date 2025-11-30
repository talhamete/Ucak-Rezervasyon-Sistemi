using System.Text.Json.Serialization;

namespace BiletRezervasyon.Varlıklar
{


    [JsonDerivedType(typeof(Pilot), typeDiscriminator: "pilot")]
    [JsonDerivedType(typeof(KabinMemuru), typeDiscriminator: "kabinMemuru")]
    public abstract class Personel
    {

        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

    }
}