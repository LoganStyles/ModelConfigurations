public class Employee{
    public long Id { get; set; }
        public string FirstName { get; set; }= null!;
        public string LastName { get; set; }= null!;
        public long Age { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
}