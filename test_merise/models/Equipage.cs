namespace test_merise.models
{
    public class Equipage
    {
        public int Id { get; set; }
        public string Nom_emp { get; set; }
        public string Prenom_emp { get; set; }
        public List<Vol> Vols { get; set; }
    }
}
