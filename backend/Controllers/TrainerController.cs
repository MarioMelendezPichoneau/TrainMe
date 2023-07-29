using APIsTrainME.Models;
using APIsTrainME.Models.ModelService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIsTrainME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {

       public readonly ITrainMeService _trainMeService;

        public TrainerController(ITrainMeService trainMeService)
        {
            _trainMeService = trainMeService;
            
        }


        [HttpPost("AddTrainer")]
        public async Task<ActionResult<List<Trainer>>> AddTrainer(Trainer trainer)
        {
            var result = await _trainMeService.AddTrainer(trainer); 
            return Ok(result);
        }

        [HttpPut("UpdateTrainer")]
        public async Task<ActionResult<List<Trainer>>> UpdateTrainer(Trainer trainer)
        {
            var user = await _trainMeService.UpdateTrainer(trainer);

            if (user is null)
            {
                return NotFound($"Entrenador {trainer.Name} No fue encontrado");
            }

            

            return Ok(user);
        }

        [HttpDelete("id")]
        public async Task<ActionResult<List<Trainer>>> DeleteTrainer(int trainerId)
        {
            var user = await _trainMeService.DeleteTrainer(trainerId);

            if (user is null)
            {
                return NotFound($"Entrenador con ID {trainerId} no encontrado");
            }

            return Ok($"Entrenador con ID {trainerId} borrado");
        }


    }
}
