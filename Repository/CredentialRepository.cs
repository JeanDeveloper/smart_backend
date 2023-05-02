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
    public class CredentialRepository : ICredentialRepository
    {
        public HabilityCredentialResponse EnabledCredential(HabilityCredentialRequest request)
        {
            var param = new
            {
                codAccion = request.actionCode,
                codigo    = request.codigo,
                usuario   = request.usuario,
                creadoPor = request.creadoPor

            };
            var query = "DECLARE @result SMALLINT; " +
                        "EXEC SOLMAR.dbo.VDAPP_APPROVE_CREDENTIAL @codAccion, @codigo, @usuario, @creadoPor, @estado_transaccion=@result OUTPUT " +
                        "SELECT @result AS estado";

            using (var connection = DbConnection.getConnection())
            {
                return connection.QueryFirstOrDefault<HabilityCredentialResponse>(query, param);
            }
        }

        public IEnumerable<CredentialByContractorResponse> GetCredentialsByContractor(CredentialByContractorRequest request)
        {
            var param = new
            {
                codCliente = request.codCliente,
                codEmpresa = request.codEmpresa,
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_CREDENCIALES_X_CONTRATISTA @codCliente, @codEmpresa";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<CredentialByContractorResponse>(query, param);
            }

        }
    }
}
