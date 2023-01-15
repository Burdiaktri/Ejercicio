using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio

{
    public class Medico
    {

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public Medico(string nombre)
        {
            if(nombre.Length > 50 || nombre.Length == 0)
            {
                throw new Exception("El nombre no puede estar vacío o superar los 50 carácteres");
            } 
            Nombre = nombre;
        }
    }
}
