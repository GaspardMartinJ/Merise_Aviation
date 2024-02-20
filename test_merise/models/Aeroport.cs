namespace test_merise.models
{
    public class Aeroport
    {
        public int Id { get; set; }
        public string Nom_aero { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public List<Vol> Vols_arr { get; set; }
        public List<Vol> Vols_dep { get; set; }
    }
}
