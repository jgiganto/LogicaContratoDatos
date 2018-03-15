using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace LogicaContratoDatos
{
    [ServiceContract]
    public interface IContratoAlumno
    {
        [OperationContract]
        List<Alumno> GetAlumnos();

        [OperationContract]
        Alumno BuscarAlumno(String idalumno);
    }
}
