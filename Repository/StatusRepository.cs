using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using smart_backend.Models.Request;
using smart_backend.Models.Response;
using smart_backend.Utilities;
using Dapper;

namespace smart_backend.Repository
{
    public class StatusRepository : IStatusRepository
    {
        public StatusResponse registerStatus(StatusRequest request)
        {
            var param = new
            {
                codSolDoc = request.codSolDoc,
                codEstado = request.codEstado,
                obs      = request.obs,
                creadoPor = request.creadoPor
            };

            var query = "DECLARE @result NUMERIC(18,0);"
                        + "EXEC SOLMAR.dbo.VDAPP_ADD_STATUS_X_DOC @codSolDoc, @codEstado, @obs, @creadoPor, @estado_transaccion = @result OUTPUT;"
                        + "SELECT @result estado;";

            using (var connection = DbConnection.getConnection())
            {
                return connection.QueryFirstOrDefault<StatusResponse>(query, param);
            }
        }
    }
}
