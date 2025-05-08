using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto10.Model;

namespace Projeto10.Services
{
    internal class RepositorioDados
    {
        private DatabaseService _databaseService;

        public RepositorioDados(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<Materia> getAllMaterias() { 
        
            List<Materia> listMaterias = new List<Materia>();

            string query = "SELECT * FROM materia";

            var reader = _databaseService.ExecuteQuery(query);

            while (reader.Read())
            {
                Materia materia = new Materia();
                materia.Id = reader.GetInt32("id");
                materia.Nome = reader["nome"].ToString();

                listMaterias.Add(materia);
            }

            return listMaterias;

        }
    }
}
