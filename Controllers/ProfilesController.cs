using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sharpblogger.Models;
using sharpblogger.Service;

namespace sharpblogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfilesController : ControllerBase
    {
        private readonly ProfilesService _service;

        public ProfilesController(ProfilesService service)
        {
            _service = service;

        }

        [HttpGet("{id}")]
        public ActionResult<Profile> Get(string id)
        {
            try
            {
                return Ok(_service.GetProfileById(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpGet("{id}/blogs")]
        public ActionResult<IEnumerable<Blog>> GetAdmissions(string id)
        {
            try
            {
                return Ok(_service.GetAdmissionsByProfileId(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}