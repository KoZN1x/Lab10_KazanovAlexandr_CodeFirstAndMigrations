namespace Lab10_KazanovAlexandr_CodeFirst.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public short Age { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; } = null!;
    }
}
