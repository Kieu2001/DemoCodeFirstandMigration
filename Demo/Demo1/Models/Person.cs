namespace Demo1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<PersonCompany> Companies { get; set; }
    }
}
