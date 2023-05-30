namespace Demo1.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PersonCompany> People { get; set; }
    }
}
