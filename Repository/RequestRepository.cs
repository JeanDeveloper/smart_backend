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
    public class RequestRepository : IRequestRepository
    {
        public IEnumerable<DetailRequestGeneralResponse> getDetailRequestGeneral(DetailRequestGeneralRequest request)
        {
            var param = new
            {
                codCabecera = request.codCabecera,
                usuario = request.userName,
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_DOCGEN_X_SOLICITUD_ADMIN @codCabecera , @usuario";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<DetailRequestGeneralResponse>(query, param);
            }

        }

        public IEnumerable<DetailRequestPersonResponse> getDetailRequestPerson(DetailRequestGeneralRequest request)
        {

            var param = new
            {
                codCabecera = request.codCabecera,
                usuario     = request.userName,
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_PERSONAL_X_SOLICITUD_ADMIN @codCabecera , @usuario";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<DetailRequestPersonResponse>(query, param);
            }

        }

        public IEnumerable<RequestByAuthorityResponse> getRequestByAuthority(RequestByAuthorityRequest request)
        {
            var param = new
            {
                codCliente = request.codCliente,
                codUsuario = request.codUsuario
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_SOLICITUD_X_AUTORIZANTE @codCliente, @codUsuario";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<RequestByAuthorityResponse>(query, param);
            }
        }

        public IEnumerable<DetailRequestPersonDocumentResponse> getListPersonsDocumentRequest(DetailRequestPersonDocumentRequest request)
        {
            var param = new
            {
                codDetPersona = request.codDetPersona,
                usuario       = request.userName
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_DOCINDIVIDUAL_X_PERSONA_ADMIN @codDetPersona, @usuario";

            using (var connection = DbConnection.getConnection())
            {
                 return connection.Query<DetailRequestPersonDocumentResponse>(query, param);
            }
        }

        public IEnumerable<PersonObservationDocumentResponse> getListObservationPersonDocument(int code)
        {
            var param = new
            {
                codSolDoc = code,
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_OBS_X_DOC @codSolDoc";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<PersonObservationDocumentResponse>(query, param);
            }
        }

        public IEnumerable<InductionCourseStatusResponse> getCourseState(InductionCourseStatusRequest request)
        {
            var param = new
            {
                RUC = request.ruc,
                NRO_DOCUMENTO = request.nroDoc,
                EMPR_CURSO  = request.enterprise,
                codeEncrypt = request.codeEncrypt,
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_NOTA_PARTICIPANTE @RUC, @NRO_DOCUMENTO,  @EMPR_CURSO, @codeEncrypt";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<InductionCourseStatusResponse>(query, param);
            }
        }

        public IEnumerable<PersonCommentDocumentResponse> getListCommentPersonDocument(int code)
        {
            var param = new
            {
                codSolDoc = code
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_COMMENTS_X_DOC @codSolDoc";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<PersonCommentDocumentResponse>(query, param);
            }
        }

        public IEnumerable<PersonsRequestResponse> GetPersonListRequest(int code)
        {
            var param = new
            {
                codCabecera = code
            };
            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_PERSONAL_X_SOLICITUD_TO_AUTORIZAR @codCabecera";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<PersonsRequestResponse>(query, param);
            }

        }

        public IEnumerable<RequestByContractorResponse> GetRequestByContractor(RequestByContractorRequest request)
        {
            var param = new
            {
                codEmpresa = request.enterPriseCode,
                codCliente = request.customerCode,
            };

            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_SOLICITUD_X_CONTRATISTA @codEmpresa, @codCliente";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<RequestByContractorResponse>(query, param);
            }
        }

        public IEnumerable<EntryTypeResponse> getListEntryType(string descripcion, string codcliente)
        {
            var param = new
            {
                descripcion = descripcion,
                codcliente = codcliente,
            };

            var query = "EXEC SICOS_TRAINING.dbo.USP_TRAINING_2022_LISTAR_TIPO_INGRESO '', @codcliente";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<EntryTypeResponse>(query, param);
            }
        }

     

        public IEnumerable<SucursalResponse> getListSucursal( string codcliente, string ambito)
        {
            var param = new
            {
                codcliente = codcliente,
                ambito = ambito,
            };

            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_SEDES_X_CLIENTE @codcliente, @ambito";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<SucursalResponse>(query, param);
            }
        }

        public IEnumerable<SedeResponse> getListSede(int codSede)
        {
            var param = new
            {
                codSede = codSede,

            };

            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_SUBSEDES_X_SEDE @codSede";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<SedeResponse>(query, param);
            }
        }

        public IEnumerable<RepresentativeResponse> getListRepresentative(int codSede)
        {
            var param = new
            {
                codSede = codSede,

            };

            var query = "EXEC SICOS_TRAINING.dbo.VD_LISTAR_AUTORIZANTE_X_SEDE @codSede";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<RepresentativeResponse>(query, param);
            }
        }

        public CreateRequestResponse createRequest(CreateRequestRequest request)
        {
            var param = new
            {
                codTipoIngreso = request.codTipoIngreso,
                codCliente = request.codCliente,
                codEmpresa = request.codEmpresa,
                codSede    = request.codSede,
                codSubSede = request.codSubSede,
                codAmbito  = request.codAmbito,
                codAutorizante = request.codAutorizante,
                fecha_inicio = request.fechaInicio,
                fecha_fin = request.fechaFin,
                creado_por = request.creadoPor,
                habilitado = request.habilitado
            };

            var query = "DECLARE @result SMALLINT, @result1 SMALLINT;" +

                        "EXEC [dbo].[VDAPP_CREAR_SOLICITUD]  @codTipoIngreso, @codCliente, @codEmpresa, @codSede, @codSubSede, @codAmbito, @codAutorizante, @fecha_inicio, @fecha_fin, @creado_por, @habilitado, @estado_transaccion = @result OUTPUT, @codCabecera_creado = @result1 OUTPUT " +

                        "SELECT @result as estado, @result1 as codCabecera ";

            using (var connection = DbConnection.getConnection())
            {
                return connection.QueryFirstOrDefault<CreateRequestResponse>(query, param);
            }

        }

        public CodeEncryptResponse updateCodeEncrypt(CodeEncryptRequest request)
        {

            var param = new
            {
                codCabecera = request.codCabecera,
                codeEncrypt = request.codeEncrypt,
            };

            var query = "EXEC [dbo].[VDAPP_UPDATE_SOLICITUD]  @codCabecera, @codeEncrypt ";


            using (var connection = DbConnection.getConnection())
            {
                return connection.QueryFirstOrDefault<CodeEncryptResponse>(query, param);
            }

        }
    }
}
