using System;

namespace Entidades_Znake
{
    public class Entidad_Dueno
    {
        public int ID_Dueno { get; private set; }
        public string nombre_Dueno { get; set; }
        public string email_Dueno { get; set; }
        private int Edad_Dueno;
        public string telefono_Dueno { get; set; }

        public int edad_Dueno
        {
            get { return Edad_Dueno; }
            set 
            {
                if (value > 0)
                {
                    Edad_Dueno = value;
                }
            }
        }
    }
}
