using Codemasters_Agenty.Data;
using Codemasters_Agenty.DataRepo;
using Codemasters_Agenty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemasters_Agenty.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AgentyJobApplicationController : ControllerBase
    {
        private readonly IMyResumeRepo _repo;

        public AgentyJobApplicationController(IMyResumeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("init")]
        public MyResume InitResume()
        {
            var id = _repo.Post(new MyResume
            {
                Name = "Ajit Hegde",
                Email = "codemasterblackperl@gmail.com",
                Phone = "8431481067",
                Experiance = 5,
                Id = 1,
                Location = "Sirsi, Karnataka, India, PIN:581401",
                Skills = new[] { "C#", "ASP.NET", "ASP.NET Core", "Vue Js", "Html", "Vuetify", "Javascript", "Css" }
            });

            return _repo.Get(id);
        }

        [HttpGet("{id}")]
        public MyResume Get([FromRoute]long id)
        {
            return _repo.Get(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]MyResume resume)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(m => m.Errors)
                                 .Select(e => e.ErrorMessage)
                                 .ToList());
            }

            return Ok(_repo.Post(resume));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]long id)
        {
            var result = _repo.Delete(id);
            if (result)
                return Ok("Successfully deleted resume");
            return NotFound();
        }
    }
}