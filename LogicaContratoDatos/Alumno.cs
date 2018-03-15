using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LogicaContratoDatos
{
    [DataContract]
    public class Alumno
    {
        [DataMember]
        public int IdAlumno { get; set; }
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public String Apellidos { get; set; }
        [DataMember]
        public int Nota { get; set; }
    }
}
