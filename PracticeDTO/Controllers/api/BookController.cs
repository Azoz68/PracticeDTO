using PracticeDTO.Dtos;
using PracticeDTO.MapConfiguration;
using PracticeDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PracticeDTO.Controllers.api
{
    public class BookController : ApiController
    {
         BookEntities db = new BookEntities();
        private MapProfile prf = new MapProfile();

         [ResponseType(typeof(UsersDto))]
        public IHttpActionResult GetUsers(int id)
        {
            var user = db.Users.Find(id);
            if(user == null)
            {
                return NotFound();
            }
            var map = prf.GetMapper();
            var result = map.Map<Users, UsersDto>(user);

            return Ok(result);
        }

        [ResponseType(typeof(UsersDto))]
        public IEnumerable<UsersDto> GetUsers()
        {
            var users = db.Users.ToList();
            var map = prf.GetMapper();
            var result = map.Map<List<Users>,List<UsersDto>>(users);
            return result;
        }
        
    }
}
