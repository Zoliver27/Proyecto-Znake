using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Znake
{
    public class Entidad_Administrador
    {
        public int ID_Administrador { get; private set; }
        public string nombre_Admin { get; set; }
        public string email_Admin { get; set; }
        public string telefono_Admin { get; set; }

        private int Edad_Admin;
        public int edad_Admin
        {
            get { return Edad_Admin; }
            set 
            { 
                if (value > 0)
                {
                    Edad_Admin = value;
                }
            }
        }
    }
}
