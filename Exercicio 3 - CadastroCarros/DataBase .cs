using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace CadastroCarros
{
    internal class Carros
    {

        public Carros() {
            var db = new LinqToDB.Data.DataConnection(
                    LinqToDB.ProviderName.MySql,
                    "Server=localhost;Database=autocars;Trusted_Connection=True;Enlist=false;");
        }


    }
}
