using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenIddict.Validation;

namespace OAuthUsingOpenIDDApplication.Controllers
{
    [Route("api/[controller]")]    
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            return new List<string>()
            {
                "Coming Up","With Token","Api Implementations"
            };
        }

        [HttpGet]
        [Route("Test")]
        [Authorize(AuthenticationSchemes = OpenIddictValidationDefaults.AuthenticationScheme)]
        public string Test()
        {
            return "Test string";
        }
    }
}