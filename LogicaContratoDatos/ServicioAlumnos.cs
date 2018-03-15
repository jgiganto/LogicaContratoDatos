using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;


namespace LogicaContratoDatos
{
  public class ServicioAlumnos:IContratoAlumno
    {
        XDocument docxml;
        public ServicioAlumnos()
        {
            //nombre del recurso que hemos guardado en nuestro ensamblado
            //nombreensamblado.recurso
            Stream stream =
                this.GetType().Assembly.GetManifestResourceStream("LogicaContratoDatos.alumnos.xml");
            docxml = XDocument.Load(stream);

        }
        public Alumno BuscarAlumno(string idalumno)
        {
            var consulta = from datos in docxml.Descendants("alumno")
                           where datos.Element("idalumno").Value==idalumno
                           select new Alumno
                           {
                               IdAlumno = int.Parse(datos.Element("idalumno").Value),
                               Nombre = datos.Element("nombre").Value,
                               Apellidos = datos.Element("apellidos").Value,
                               Nota = int.Parse(datos.Element("nota").Value)

                           };
            return consulta.FirstOrDefault();

        }

        public List<Alumno> GetAlumnos()
        {
            var consulta = from datos in docxml.Descendants("alumno")
                           select new Alumno
                           {
                               IdAlumno = int.Parse(datos.Element("idalumno").Value),
                               Nombre = datos.Element("nombre").Value,
                               Apellidos = datos.Element("apellidos").Value,
                               Nota = int.Parse(datos.Element("nota").Value)

                           };
            return consulta.ToList();
           
        }
    }
}
