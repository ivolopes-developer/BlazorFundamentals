using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorCRUD.Models;

namespace BlazorCRUD.Data
{
    public class BlazorCRUDContext : DbContext
    {
        public BlazorCRUDContext (DbContextOptions<BlazorCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorCRUD.Models.Student> Student { get; set; } = default!;
    }
}
