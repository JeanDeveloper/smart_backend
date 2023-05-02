using smart_backend.Models.Solicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Response
{
    public class DetailRequestGeneralResponse
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public bool tieneLista{ get; set; }
        public int codDocumento { get; set; }
        public DateTime fechaCarga{ get; set; }
        public DateTime fechaEmision { get; set; }
        public DateTime fechaCaducidad { get; set; }
        public string rutaArchivo { get; set; }
        public string estadoDoc { get; set; }
        public int aprobado { get; set; }
        public string estado { get; set; }
        public string estado2 { get; set; } = null;
        public string observaciones { get; set; } = null;
        public bool permisoAprobacion{ get; set; }
    }


    public class DetailRequestPersonResponse
    {
        public string fullname { get; set; }
        public string nroDoc { get; set; }
        public string cargo { get; set; }
        public string area { get; set; }
        public string motivo { get; set; }
        public string tipotrabajo { get; set; }
        public DateTime fecha_ini_per { get; set; }
        public DateTime fecha_fin_per { get; set; }
        public int codDetPersona { get; set; }
        public int cumple { get; set; }
        public bool completado { get; set; }
        public int no_cumple { get; set; }
        public int porcentaje { get; set; }
        public int hay_obs { get; set; }
        public int aprobado { get; set; }
        public bool tieneQR{ get; set; }
        public bool autorizado { get; set; }
        public bool permisoAprobacion { get; set; }
        public int estadoBloqueado { get; set; }
    }



    public class DetailRequestPersonDocumentResponse
    {
        public int codigo { get; set; }
        public int codEstadoSolDoc { get; set; }
        public int codDoc { get; set; }
        public string nombre { get; set; }
        public bool cargadoVerificador { get; set; }
        public String fechaCarga { get; set; }
        public String fechaEmision { get; set; }
        public String fechaCaducidad { get; set; }
        public string dosis { get; set; }
        public string rutaArchivo { get; set; }
        public bool estado_fecha { get; set; }
        public int aprobado { get; set; }
        public string estado { get; set; }
        public string observaciones { get; set; }
        public int permisoAprobacion { get; set; }
    }

    public class PersonObservationDocumentResponse
    {
        public string observacion { get; set; }
        public DateTime creado { get; set; }
    }
    public class PersonCommentDocumentResponse
    {
        public string observacion { get; set; }
        public DateTime creado { get; set; }
    }

    public class InductionCourseStatusResponse
    {
        public string estado { get; set; }
        public DateTime? fechaEmision { get; set; }
        public DateTime? fechaCaducidad { get; set; }

    }

    public class PersonsRequestResponse
    {
        public string  fullname{ get; set; }
        public string nroDoc{ get; set; }
        public string ruc{ get; set; }
        public DateTime fecha_ini_per{ get; set; }
        public DateTime fecha_fin_per { get; set; }
        public int aprobado { get; set; }
        public bool induccion { get; set; }
        public int autorizado { get; set; }
        public int estadoTotal { get; set; }
        public int codDetPersona { get; set; }
        public string fecha { get; set; }

    }

    public class EntryTypeResponse
    {
        public int CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        

    }

    public class SucursalResponse
    {
        public int codigo { get; set; }
        public string codCliente { get; set; }
        public string descripcion { get; set; }
        public bool habilitado { get; set; }
        public int codSucursal { get; set; }
        public int ambito { get; set; }



    }

    public class SedeResponse
    {
        public int codigo { get; set; }
        public string subsede { get; set; }
    }

    public class RepresentativeResponse
    {
        public string PERSONAL { get; set; }
        public string nroDoc { get; set; }
        public string CODIGO_PERS { get; set; }

    }
};

