using CienteContratoDatos.ServicioAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace CienteContratoDatos.Controllers
{
    public class AlumnosController : Controller
    {
        ServicioAlumnos.ContratoAlumnoClient cliente;
        
        public AlumnosController()
        {
            cliente = new ServicioAlumnos.ContratoAlumnoClient();

        }
        // GET: Alumnos
        public ActionResult Index()
        {
            Alumno[] alumnos = cliente.GetAlumnos();
            return View(alumnos);
        }
        public ActionResult Details(String idalumno)
        {
            Alumno alumno = cliente.BuscarAlumno(idalumno);
            return View(alumno);
        }

    }
}