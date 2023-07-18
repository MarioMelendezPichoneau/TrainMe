namespace APIsTrainME.Models
{
    public class Usuario
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }


    }
}
