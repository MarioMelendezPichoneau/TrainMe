using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APIsTrainME.Models
{
    public class Trainer
    {
        
        public int TrainerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Foto { get; set; }
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
