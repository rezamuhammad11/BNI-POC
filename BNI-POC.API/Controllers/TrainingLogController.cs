using BNI_POC.API.Provider;
using BNI_POC.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI_POC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingLogController : ControllerBase
    {
        private readonly ITrainingLogProvider _trainingLogProvider;

        public TrainingLogController(ITrainingLogProvider trainingLogProvider)
        {
            _trainingLogProvider = trainingLogProvider;
        }

        [HttpPost("[action]")]
        public IActionResult Save(TrainingLogViewModel model)
        {
            try
            {
                var data = _trainingLogProvider.Save(model);
                return Ok(data);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
