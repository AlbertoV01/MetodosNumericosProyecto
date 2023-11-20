using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_Numéricos_401
{
    public class Falsa_Posicion:Biseccion //Se creó una clase para realizar las funciones pero como casi todos los metodos son iguales se hace uso de la herencia
        // heredando así los métodos de bisección ya creados anteriormente
    {
       public Falsa_Posicion(float xl, float xu, string funcion, float P, float xranterior):base(xl,  xu,  funcion,  P,  xranterior) // Se creó el constructor 
            // haciendo referencia a los mismos parámetros que tomamos en la clase de bisección
        {


        }

  

        public override float CalcularXr() // Aplicamos la sobreescritura del único método que cambia y realizamos las operaciones distintas aquí
        {
            xr = xu - (fxu * (xl - xu) / (fxl - fxu));
            return xr;
        }



    }
}
