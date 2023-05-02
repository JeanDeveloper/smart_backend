using smart_backend.Models.Request;
using smart_backend.Models.Response;
using smart_backend.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace smart_backend.Repository
{
    public class ContractorRepository : IContractorRepository
    {
        public IEnumerable<ContractorByCustomerResponse> GetContractorsByCustomer(ContractorByCustomerRequest request)
        {
            var param = new
            {
                codCliente = request.customerCode
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_CONTRATISTAS_X_CLIENTE @codCliente";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<ContractorByCustomerResponse>(query, param);
            }

        }
    }
}
