using Microsoft.AspNetCore.Mvc;

namespace APIsTrainME.Models.ModelService
{
    public interface ITrainMeService
    {
        List<Trainer> AddTrainer(Trainer trainer);
        Task<List<Trainer>?> UpdateTrainer(Trainer trainer);
        List<Trainer> DeleteTrainer(int trainerId);

        Task<List<RecervarSesion>> Agendar(Agendar ag);
        Task<Usuario?> Getagendar(int id);
        Task<List<Usuario>> GetAllUsers();
        Task<Usuario> Get(string userSh);
        Task<List<Usuario>?> AddUser(Usuario hero);
        Task<Usuario> Login(UserLoginService request);
        Task<List<Usuario>?> UpdateHero(Usuario request);
        Task<List<Usuario>?> DeleteUsers(int id);
    }
}
