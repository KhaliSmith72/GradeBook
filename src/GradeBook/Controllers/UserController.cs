using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GradeBook.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private UserService _bService;


        public UserController(UserService us)
        {
            _bService = us;
        }

        [HttpGet]
        [Authorize]

        public IEnumerable<ClassDTO> UserDetails()
        {
            return _bService.GetClassesForUser(User.Identity.Name);
        }
        [HttpPost]

        public IActionResult AddClass([FromBody] ClassDTO Class, string currentUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _bService.AddClasses(Class, User.Identity.Name);
            return Ok();
        }
    }
}
