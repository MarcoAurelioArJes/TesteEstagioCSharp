using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Mapping;

namespace CadastroCarros
{
    [Table(Name = "CarrosTbl")]
    public class Carros
    {
        [Column(Name = "Modelo"), NotNull]
        public string Modelo { get; set; }
        
        [Column(Name = "Placa"), NotNull]
        public string Placa { get; set; }

        [Column(Name = "Chassi"), PrimaryKey]
        public string Chassi { get; set; }
        
        [Column(Name = "Ano"), NotNull]
        public string Ano { get; set; }

        [Column(Name = "Marca"), NotNull]
        public string Marca { get; set; }

        public void Insere(Carros carro) {
            using (var db = new CarrosDb()) { 
                db.Insert(carro);
            }
        }
        public List<Carros> Listar()
        {
            using (var db = new CarrosDb())
            {
                var query = from carros in db.Carros
                            select carros;

                return query.ToList();
            }
        }

        public List<Carros> ListarBusca(string busca) { 
            using (var db = new CarrosDb()) { 
            
                var query = from carros in db.Carros
                            where carros.Marca.Contains(busca) 
                                  || carros.Modelo.Contains(busca)
                                  || carros.Chassi.Contains(busca)
                            select carros;

                return query.ToList();
            }
        }


        public void Excluir(string chassi) {
            using (var db = new CarrosDb())
            {
                db.Carros
                .Where(carro => carro.Chassi.Contains(chassi))
                .Delete();
            }
        }

        public void Atualizar(string chassi, string modelo, string placa, string marca, string ano) {
            using (var db = new CarrosDb())
            {
                db.Carros
                .Where(carro => carro.Chassi == chassi)
                .Set(carro => carro.Modelo, modelo)
                .Set(carro => carro.Placa, placa)
                .Set(carro => carro.Marca, marca)
                .Set(carro => carro.Ano, ano)
                .Update();
            }
        }
    }
}
