using AP1_P1_Steven.Models;
using Microsoft.EntityFrameworkCore;

namespace AP1_P1_Steven.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Modelo> Modelos { get; set; }
    }
}