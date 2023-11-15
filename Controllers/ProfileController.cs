using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using profileAPi.Data;
using profileAPi.Models;

namespace profileAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    

    public class ProfileController : ControllerBase
    {

        
        private readonly DataContext context;
        
        public ProfileController(DataContext _context)
        {
            context = _context;
        }
        
        [HttpGet("profile")]
        public IActionResult getData()
        {
            
            

            IQueryable<Profile> query = context.ProfileData;

            var profileData = query.ToList();

            return Ok(profileData);
        }

        [HttpPost("registerData")]
        public IActionResult postData(Profile request)
        {

            /*
            var Profile = new {
                name="Victor",
                lastname="Veliz Cruz",
                age="24",
                email="victor.veliz@alumnos.ucn.cl",
                city="Antofagasta",
                country="Chile",
                summary="M",
                frameworks=[
                    {
                        name="React",
                        date="01-01-2022",
                        learned="no"

                    }
                ]

            };
            */
            var profileData = new Profile {
                Name = request.Name,
                Lastname = request.Lastname,
                Email = request.Email,
                City = request.City,
                Summary = request.Summary,
                Frameworks = request.Frameworks,
                Hobbies = request.Hobbies
            };

            context.ProfileData.Add(profileData);
            context.SaveChanges();

            return Ok();
        }
    }
}