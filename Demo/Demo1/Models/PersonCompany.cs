using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Models
{
    public class PersonCompany
    {
        public int Id { get; set; }
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        public bool Current { get; set; }
        public string Position { get; set; }

        [ForeignKey(nameof(Person))]
        public int RefToPerson { get; set; }

        [ForeignKey(nameof(Company))]
        public int RefToCompany { get; set; }
        public Person Person { get; set; }
        public Company Company { get; set; }
    }
}
