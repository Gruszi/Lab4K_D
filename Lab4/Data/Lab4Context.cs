using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using K_DLab4.Models;

namespace K_DLab4.Data
{
    public class K_DLab4Context : DbContext
    {
        public K_DLab4Context (DbContextOptions<K_DLab4Context> options)
            : base(options)
        {
        }

        public DbSet<K_DLab4.Models.Song> Song { get; set; }
    }
}
