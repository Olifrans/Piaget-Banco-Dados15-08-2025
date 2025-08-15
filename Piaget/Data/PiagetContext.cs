using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Piaget.Models;

namespace Piaget.Data
{
    public class PiagetContext : DbContext
    {
        public PiagetContext (DbContextOptions<PiagetContext> options)
            : base(options)
        {
        }

        public DbSet<Piaget.Models.Aluno> Aluno { get; set; } = default!;
    }
}
