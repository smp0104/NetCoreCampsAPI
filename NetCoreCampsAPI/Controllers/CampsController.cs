using Microsoft.AspNetCore.Mvc;
using NetCoreCampsAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCampsAPI.Controllers
{
    [Route("api/camps")]
    [Produces("application/json")]
    public class CampsController:ControllerBase
    {
        private readonly ICampRepo campRepo;

        public CampsController(ICampRepo campRepo)
        {
            this.campRepo = campRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetCamps()
        {
            var results = await campRepo.GetAllCampsAsync();
            return Ok(results);
        }
        [HttpGet("{moniker}")]
        public async Task<IActionResult> GetMoniker(string moniker)
        {
            try
            {
                var result = await campRepo.GetCampAsync(moniker);
                if (result == null)
                {
                    return NotFound($"Not result found for {moniker}");
                }    
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
        }
    }
}
