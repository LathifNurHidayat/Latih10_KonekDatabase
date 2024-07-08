using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih10_KonekDatabase
{
    public  class SekolahKuDbContext : DbContext
    {
        public DbSet<SiswaModel> SISWA { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost; Database=Db_KerjaPraktek; Trusted_Connection = True ;TrustServerCertificate=True");
        }
    }

}
