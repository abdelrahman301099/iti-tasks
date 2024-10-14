namespace MVCDay2.Models
{
    public class Drugs
    {
        List<Drug> drugs = new List<Drug>();

        public Drugs()
        {
            drugs.Add(new Drug() { Id = 1, Description = "Pain reliever", Name = "Aspirin", Image = "aspirin_image" });
            drugs.Add(new Drug() { Id = 2, Description = "Antibiotic", Name = "Amoxicillin", Image = "amoxicillin_image" });
            drugs.Add(new Drug() { Id = 3, Description = "Cough syrup", Name = "Robitussin", Image = "robitussin_image" });
            drugs.Add(new Drug() { Id = 4, Description = "Cold medication", Name = "NyQuil", Image = "nyquil_image" });
            drugs.Add(new Drug() { Id = 5, Description = "Allergy medication", Name = "Benadryl", Image = "benadryl_image" });
            drugs.Add(new Drug() { Id = 6, Description = "Antidepressant", Name = "Sertraline", Image = "sertraline_image" });
        }

        public List<Drug> GetAll()
        {
            return drugs;
        }

        public Drug Details(int id)
        {
           Drug drug = drugs.FirstOrDefault(d=> d.Id == id);
            return drug;
        }
    }
}
