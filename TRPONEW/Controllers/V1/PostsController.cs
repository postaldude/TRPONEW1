using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TRPONEW.Contracts.V1;
using TRPONEW.Domain;

namespace TRPONEW.Controllers.V1
{
    public class PoststController : Controller
    {
        private List <Post> _posts;

        public PoststController()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString()});
            }
        }
        

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetALL()
        {
            return Ok(_posts);
        }
    }
}