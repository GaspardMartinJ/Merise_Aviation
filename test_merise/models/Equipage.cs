namespace test_merise.models
{
    public class Equipage
    {
        public int num_employe { get; set; }
        public string nom_emp { get; set; }
        public string prenom_emp { get; set; }
        public List<Vol> vols { get; set; }
    }
}
