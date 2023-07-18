namespace APIsTrainME.Models
{
    public class RecervarSesion
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int TrainerId { get; set; }
        public int UserId { get; set; }

        public virtual Trainer Trainer { get; set; }
        public virtual Usuario User { get; set; }
    }
}
