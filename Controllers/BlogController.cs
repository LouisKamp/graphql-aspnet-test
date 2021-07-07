using System.Collections.Generic;
using System.Linq;
using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using Microsoft.EntityFrameworkCore;

namespace dotnetgraphql
{
    public class BlogController : GraphController
    {
        private readonly BloggingContext _context;

        public BlogController(BloggingContext context)
        {
            this._context = context;
        }


        [QueryRoot]
        public IEnumerable<Blog> Blogs() => _context.Blogs;

    }
}