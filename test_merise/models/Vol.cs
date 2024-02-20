namespace test_merise.models
{
    public class Vol
    {
        public int num_vol { get; set; }
        public DateOnly jour_depart { get; set;}
        public TimeOnly heure_depart { get; set;}
        public int nb_places_vendues { get; set;}
        public int num_avion { get; set;}
        public List<Passager> passagers { get; set;}
        public int code_aero_dep { get; set;}
        public int code_aero_arr { get; set;}
        public List<Equipage> personnel { get; set;}
    }
}
