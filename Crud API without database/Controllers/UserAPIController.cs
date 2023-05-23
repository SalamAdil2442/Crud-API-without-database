using Crud_API_without_database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_API_without_database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
         
    {
        private static List<Users> callusers = new List<Users>
        {  
        new Users
            {
            ID=1,
            Name="Salam",
            Email="Salamadilsaidan@gmail.com",
            GitHub="SalamAdil2442",
            Password=1234567890,
            Place="Erbil"
            },       new Users
            {
            ID=2,
            Name="ahmad",
            Email="ahmadadil@gmail.com",
            GitHub="username",
            Password=1234567890,
            Place="erbil"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Users>>> get()
        {
            return Ok(callusers);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Users>>> get( int id)
        {
            var usersID = callusers.Find(h=> h.ID==id);
            if (usersID == null)
            {
                return BadRequest("NOT FOUND");
            }
            return Ok(usersID);
        }
        [HttpPost]
        public async Task<ActionResult<List<Users>>> post(Users adduser)
        {
            callusers.Add(adduser);
            return Ok(callusers);
        }

        [HttpPut]
        public async Task<ActionResult<List<Users>>> Update(Users edit)
        {
            var useredit=callusers.Find(h => h.ID==edit.ID);
            if (useredit == null)
            {
                return BadRequest("NOT FOUND");

                
            }
            useredit.ID = edit.ID;
         useredit.Name=edit.Name;
            useredit.Password=edit.Password;
            useredit.Place=edit.Place;
            useredit.Email=edit.Email;
            useredit.GitHub=edit.GitHub;
            return Ok(useredit);
         
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Users>>> delete(int id) {
            var deletuser = callusers.Find(h => h.ID == id)
                    ;
            if(deletuser == null)
            {
                return BadRequest("NOT FOUND");
            }
            callusers.Remove(deletuser);
            return Ok(deletuser);
                }

    }
}
