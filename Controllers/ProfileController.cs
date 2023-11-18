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

            IQueryable<Framework> frameworkQuery = context.FrameworkData;
            IQueryable<Hobby> hobbyQuery = context.HobbyData;

            var frameworklist = frameworkQuery.ToList();
            var hobbylist = hobbyQuery.ToList();
            
            var profileData = new {
                query
            };
            

            return Ok(profileData);
        }

        [HttpPost("registerPersonalData")]
        public IActionResult PersonalData(Profile request)
        {
            

            var profileData = new Profile {
                Name = request.Name,
                Lastname = request.Lastname,
                Email = request.Email,
                Age = request.Age,
                Country = request.Country,
                City = request.City,
                Summary = request.Summary,
                Frameworks = request.Frameworks,
                Hobbies = request.Hobbies
            };

            context.ProfileData.Add(profileData);
            context.SaveChanges();

            return Ok();
        }

        [HttpPost("registerFrameworkData")]
        public IActionResult FrameworkData(Framework request)
        {
            var newFramework = new Framework {
                FrameworkName = request.FrameworkName,
                FrameworkDate = request.FrameworkDate,
                IsLearned = request.IsLearned
            };

            context.FrameworkData.Add(newFramework);
            context.SaveChanges();
            return Ok(newFramework);
        }

        [HttpPost("registerHobbyData")]
        public IActionResult HobbyData(Hobby request)
        {
            var newHobby = new Hobby {
                HobbyName = request.HobbyName
            };

            context.HobbyData.Add(newHobby);
            context.SaveChanges();
            return Ok(newHobby);
        }

    }
}