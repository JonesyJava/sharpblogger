using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sharpblogger.Models;
using sharpblogger.Service;

namespace sharpblogger.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // REVIEW this tag enforces the user must be logged in
    [Authorize]
    public class AccountsController : ControllerBase
    {
        private readonly ProfilesService _service;

        public AccountsController(ProfilesService service)
        {
            _service = service;
        }

        [HttpGet]
        // REVIEW async calls must return a System.Threading.Tasks, this is equivalent to a promise in JS
        public async Task<ActionResult<Profile>> GetAsync()
        {
            try
            {
                // REVIEW how to get the user info from the request token
                // same as to req.userInfo
                //MAKE SURE TO BRING IN codeworks.auth0provider
                Profile userInfo = await HttpContext.GetUserInfoAsync<Profile>();
                return Ok(_service.GetOrCreateProfile(userInfo));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet("blogs")]
        public async Task<ActionResult<IEnumerable<Blog>>> GetAdmissions()
        {
            try
            {
                Profile userInfo = await HttpContext.GetUserInfoAsync<Profile>();
                return Ok(_service.GetAdmissionsByProfileId(userInfo.Id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}