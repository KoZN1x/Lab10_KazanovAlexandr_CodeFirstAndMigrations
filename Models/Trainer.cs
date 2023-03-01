namespace Lab10_KazanovAlexandr_CodeFirst.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public string? Country { get; set; }
        public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}
