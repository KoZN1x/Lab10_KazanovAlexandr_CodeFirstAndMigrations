namespace Lab10_KazanovAlexandr_CodeFirst.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public int TrainerId { get; set; }
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
        public virtual Trainer Trainer { get; set; } = null!;

    }
}
