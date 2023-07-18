namespace APIsTrainME.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string Name { get; set; }
        public int Edad { get; set; }
        public int Experiencia { get; set; }
        public string Especialidad { get; set; }
        public string Descripcion { get; set; }
        public int Calificacion { get; set; }

        //public List<Usuario> Users { get; set; } 

        //public Trainer()
        //{
        //    Users = new List<Usuario>();
        //}

    }
}
