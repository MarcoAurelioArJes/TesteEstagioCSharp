using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;

namespace CadastroCarros {
    public class CarrosDb : LinqToDB.Data.DataConnection { 
        public CarrosDb() : base("Carros") { }
        public ITable<Carros> Carros => this.GetTable<Carros>();
    }
}