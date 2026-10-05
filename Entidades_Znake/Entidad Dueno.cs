using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Znake
{
    public class Entidad_Dueno
    {
        private int ID_Dueno;
        private string Nombre;
        private string Email;
        private int Edad;
        private string Telefono;

        public int id_dueno
        {
            get { return ID_Dueno; }
            set { ID_Dueno = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public string telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public Entidad_Dueno(int id, string name, string email, int edad, string tef)
        {
            id_dueno = id;
            nombre = name;
            this.email = email;
            this.edad = edad;
            telefono = tef;
        }
    }
}
