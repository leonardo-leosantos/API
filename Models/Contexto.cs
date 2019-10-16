using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CadPessoa.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        //public System.Data.Entity.DbSet<CadPessoa.Models.Pessoa> Pessoas { get; set; }
    }
}