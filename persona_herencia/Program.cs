using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase papá 
    {
        //variables 
        //atributos
        //metodos
        //se colocara la informacion necesaria que se apoyara la con la informacion
        //se colocara el nombre, edad, fecha de nacimiento, donde agarrara tendra
        //la informacion guardada como en cajones
        protected string nombre;
        protected string fecha_Na;
        protected int edad;
        protected string Resultado;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Fecha_Na
        {
            get { return fecha_Na; }
            set { fecha_Na = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
    class Alumno : Persona //clase hija 
    {
        protected int matricula;
        protected string carrera;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Alumno(string nombre, int edad, string fecha_na, string carrera, int matricula)
        {
            Nombre = nombre;
            Edad = edad;
            Fecha_Na = fecha_na;
            Carrera = carrera;
            Matricula = matricula;
        }
    }
    class Empleado : Persona //clase Empleado
    {
        protected string puesto;
        protected float salario;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Empleado(string nombre, int edad, string fecha_na, string puesto, float sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            Fecha_Na = fecha_na;
            Puesto = puesto;
            Salario = sueldo;
        }
    }
    class Docente : Persona //clase Docente
    {
        protected string puesto;
        protected float salario;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Docente(string nombre, int edad, string fecha_Na, string puesto, float sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            Fecha_Na = fecha_Na;
            Puesto = puesto;
            Salario = sueldo;
        }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
