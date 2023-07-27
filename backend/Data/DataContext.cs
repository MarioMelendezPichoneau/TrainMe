 global using APIsTrainME.Models;
global using Microsoft.EntityFrameworkCore;

namespace APIsTrainME.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source= mariomp01.database.windows.net;Database=TrainMe;User Id= mariomp01; Password=20020322Mario2486; MultipleActiveResultSets=True;");
        }


        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RecervarSesion> RecervarSesions { get; set; }
    }
}
