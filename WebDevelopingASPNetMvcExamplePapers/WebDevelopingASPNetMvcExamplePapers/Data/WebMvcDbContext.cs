using System;
using Microsoft.EntityFrameworkCore;
using WebDevelopingASPNetMvcExamplePapers.Models;

namespace WebDevelopingASPNetMvcExamplePapers.Data
{
	public class WebMvcDbContext : DbContext
    {
		public WebMvcDbContext(DbContextOptions options) : base(options)
        {
		}

		public DbSet<Employee> Employees { get; set; }
	}
}

