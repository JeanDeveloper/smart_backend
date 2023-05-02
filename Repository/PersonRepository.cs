using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using smart_backend.Models.Response;
using Dapper;
using smart_backend.Utilities;

namespace smart_backend.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<GeneralDocumentPerson> getListPersonDocList(int code)
        {
            var param = new
            {
                codSolDoc = code
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_PERSONAL_DOC_LISTA @codSolDoc";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<GeneralDocumentPerson>(query, param);
            }

        }
    }
}
