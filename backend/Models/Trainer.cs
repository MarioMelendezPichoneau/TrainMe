using System.ComponentModel.DataAnnotations;

namespace APIsTrainME.Models
{
    public class Trainer
    {
        
        public int TrainerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Edad { get; set; } 
        public int Experiencia { get; set; } 
        public string Especialidad { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int Calificacion { get; set; }

        //public List<Usuario> Users { get; set; } 

        //public Trainer()
        //{
        //    Users = new List<Usuario>();
        //}

    }
}
