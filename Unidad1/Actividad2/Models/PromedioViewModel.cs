using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad2.Models
{
    public class PromedioViewModel
    {
        
            public float Calif1 { get; set; }
            public float Calif2 { get; set; }
            public float Calif3 { get; set; }



            public float Suma { get { return Calif1 + Calif2 + Calif3; } }



            public float Promedio
            {
                get
                {
                    return (Suma / 3);
                }
            }



            public string EstadoUsuario()
            {
                {
                    if (Promedio == 0)
                    {
                        return "Sin calificar";
                    }
                    else if (Promedio >= 70)
                    {
                        return "Aprobado";
                    }
                    else
                    {
                        return "Reprobado";
                    }
                }
            }
        }
    }
