namespace test_merise.models
{
    public class Aeroport
    {
        public int code_aero { get; set; }
        public string nom_aero { get; set; }
        public string ville { get; set; }
        public string pays { get; set; }
        public List<Vol> vols_arr { get; set; }
        public List<Vol> vols_dep { get; set; }
    }
}
