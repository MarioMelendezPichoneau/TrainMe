using Microsoft.AspNetCore.Mvc;

namespace APIsTrainME.Models.ModelService
{
    public interface ITrainMeService
    {
        Task<List<Trainer>?> AddTrainer(Trainer trainer);
        Task<List<Trainer>?> UpdateTrainer(Trainer trainer);
        Task<List<Trainer>> DeleteTrainer(int trainerId);

        Task<List<RecervarSesion>> Agendar(Agendar ag);
        Task<RecervarSesion?> Getagendar(int id);
        Task<List<Usuario>> GetAllUsers();
        Task<Trainer> Get(string userSh);
        Task<List<Usuario>?> AddUser(Usuario hero);
        Task<Usuario> Login(UserLoginService request);
        Task<List<Usuario>?> UpdateUsuario(Usuario request);
        Task<List<Usuario>> DeleteUsers(int id);
    }
}
