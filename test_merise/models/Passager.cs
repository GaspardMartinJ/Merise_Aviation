namespace test_merise.models
{
    public class Passager
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Num_place { get; set; }
        //public List<Passager> voisins { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
