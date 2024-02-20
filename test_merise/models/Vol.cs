namespace test_merise.models
{
    public class Vol
    {
        public int Id { get; set; }
        public DateOnly Jour_depart { get; set;}
        public TimeOnly Heure_depart { get; set; }
        public int Nb_places_vendues { get; set;}
        public int AvionId { get; set;}
        public List<Reservation> Reservations { get; set; }
        public int Code_aero_dep { get; set;}
        public int Code_aero_arr { get; set;}
        public List<Equipage> Personnel { get; set;}
    }
}
