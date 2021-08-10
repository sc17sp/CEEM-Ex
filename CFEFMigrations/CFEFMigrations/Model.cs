﻿using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace CFEFMigrations
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string url { get; set; }
    }
}
