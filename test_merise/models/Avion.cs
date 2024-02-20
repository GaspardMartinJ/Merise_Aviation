namespace test_merise.models
{
    public class Avion
    {
        public int Id { get; set; }
        public string Compagnie { get; set; }
        public string Modele { get; set; }
        public int Capacite { get; set; }
        public List<Vol> Vols { get; set; }
    }
}
