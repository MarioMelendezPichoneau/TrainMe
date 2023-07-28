using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Globalization;

namespace APIsTrainME.Models.ModelService
{
    public class TrainMeService : ITrainMeService
    {

        //public static List<Trainer> trainers = new List<Trainer>
        //{
        //    new Trainer
        //    {
        //        TrainerId = 1,
        //        Name = "Luca",
        //        Edad = 35,
        //        Experiencia = 10,
        //        Especialidad = "skdhhadhass",
        //        Descripcion = "123",
        //        Calificacion = 5


        //    },
        //    new Trainer
        //    {
        //        TrainerId = 2,
        //        Name = "Trainer1",
        //        Edad = 35,
        //        Experiencia = 10,
        //        Especialidad = "skdhhadhass",
        //        Descripcion = "123",
        //        Calificacion = 5
        //    }
        //};

        private readonly DataContext _context;

        public TrainMeService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<List<Trainer>?> AddTrainer(Trainer trainer)
        {
            // Asignar una foto predeterminada si no se proporcionó ninguna foto en el objeto Trainer
            if (string.IsNullOrEmpty(trainer.Foto))
            {
                // Aquí puedes establecer la URL de una foto predeterminada o cualquier otro valor por defecto
                trainer.Foto = "https://th.bing.com/th/id/R.97257fc69dc1e776b3e633d25f1c0e80?rik=tfK05WsXLoEozw&pid=ImgRaw&r=0";
            }

            //trainers.Add(trainer);
            _context.Trainers.Add(trainer);

           // return trainers;

            await _context.SaveChangesAsync();
            return await _context.Trainers.ToListAsync();
        }

        public async Task<List<Usuario>?> AddUser(Usuario hero)
        {
            _context.Usuarios.Add(hero);
            await _context.SaveChangesAsync();
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<List<RecervarSesion>> Agendar(Agendar ag)
        {
            var user = await _context.Usuarios.FindAsync(ag.UserId);
            var trainer = await _context.Trainers.FindAsync(ag.TrainerId);

            if (user == null & trainer == null)
            {
                return null;
            }

            var nuevaReserva = new RecervarSesion
            {
                Id = ag.Id,
                Date = ag.Date,
                Location = ag.Location,
                TipoEntrenamiento = ag.TipoEntrenamiento,
                Trainer = trainer,
                User = user
            };

            _context.RecervarSesions.Add(nuevaReserva);
            await _context.SaveChangesAsync();




            return await _context.RecervarSesions.ToListAsync();
        }

        public async Task<List<Trainer>> DeleteTrainer(int trainerId)
        {
            var user = await _context.Trainers.FindAsync(trainerId);

            if (user is null)
                return null;

            _context.Trainers.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Trainers.ToListAsync();
        }

        public async Task<List<Usuario>> DeleteUsers(int id)
        {
            var user = await _context.Usuarios.FindAsync(id);

            if (user is null)
                return null;

            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Trainer> Get(string userSh)
        {
            var user = await _context.Trainers.FirstOrDefaultAsync(u => u.Name == userSh);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<RecervarSesion?> Getagendar(int id)
        {
            var user = await _context.RecervarSesions.FindAsync(id);
            if (user is null)
                return null;

            return user;
        }

        public async Task<List<Usuario>> GetAllUsers()
        {
            var user = await _context.Usuarios.ToListAsync();

            return user;
        }

        public async Task<Usuario> Login(UserLoginService request)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user is null)
                return null;

            return user;
        }

        public async Task<List<Usuario>?> UpdateUsuario(Usuario request)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(t => t.UserId == request.UserId);
            if (user is null)
                return null;

            user.Name = request.Name;
            user.Email = request.Email;
            user.Password = request.Password;

            await _context.SaveChangesAsync();
            
            return new List<Usuario> { user };

        }


        public async Task<List<Trainer>?> UpdateTrainer(Trainer trainer)
        {
            var user = await _context.Trainers.FirstOrDefaultAsync(t => t.TrainerId == trainer.TrainerId);

            if (user == null)
            {
                return null;
            }

            user.Name = trainer.Name;
            user.Foto = trainer.Foto;
            user.Edad = trainer.Edad;
            user.Experiencia = trainer.Experiencia;
            user.Especialidad = trainer.Especialidad;
            user.Descripcion = trainer.Descripcion;
            user.Calificacion = trainer.Calificacion;

            await _context.SaveChangesAsync();

            return await _context.Trainers.ToListAsync();
        }




       
    }
}
