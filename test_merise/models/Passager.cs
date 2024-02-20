namespace test_merise.models
{
    public class Passager
    {
        public int num_passag { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int num_place { get; set; }
        //public List<Passager> voisins { get;}
        public List<(Vol, DateTime)> resevation { get;}
    }
}
