using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LGroup.ActiveRecord.Model.Database
{
    public sealed class Conexao : DbContext
    {
        static string _serverName = "ANDREMIRANDA-PC";
        static string _dbName = "SISCONTATOS";

        //string connStr = String.Format("Data Source={0}, Initial Catalog={1}, User Id={2}, Password{3}");
        static string connStr = String.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=True", _serverName, _dbName);

        public DbSet<ContatoModel> Contato { get; set; }
        public DbSet<SexoModel> Sexo { get; set; }
        public DbSet<EstadoCivilModel> EstadoCivil { get; set; }

        public Conexao()
            : base(connStr)
        {

        }
    }
}
