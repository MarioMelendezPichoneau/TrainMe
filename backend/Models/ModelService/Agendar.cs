namespace APIsTrainME.Models.ModelService
{
    public class Agendar
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string TipoEntrenamiento { get; set; }
        public int TrainerId { get; set; }
        public int UserId { get; set; }
    }
}
