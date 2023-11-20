using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;
namespace Métodos_Numéricos_401
{

    public class Biseccion // Se creó una clase para el metodo biseccion
    {
        public Biseccion(float xl, float xu, string funcion, float P, float xranterior) // Se creó un constructor para tomar las variables 
        {
            this.xl = xl;
            this.xu = xu;
            this.funcion = funcion;
            this.P = P;
            this.xranterior = xranterior;
           
        }
        public float xranterior { get; set; }   // Se crearon las propiedades de la clase
        private string funcion { get; set; }
        public float xl { get; set; }
        public float xu { get; set; }
        public float xr { get; set; }
        public float fxl { get; set; }
        public float fxu { get; set; }
        private float fxr { get; set; }
        private float fxlfxr { get; set; }
        private float P { get; set; }
        private float ERP { get; set; }
        public float Ea { get; set; }
        public int i { get; set; }

        Calculo AnalizadorDeFunciones = new Calculo(); // Creamos un objeto de tipo calculo gracias a la libreria que importamos para analizar la funcion

        // Se creo un método que devuelve el resultado para cada columna
        public virtual float CalcularXr()
        {
            xr = (xl + xu) / 2;
            
            return xr;
        }

        public float Calcularfxl()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
            {
                fxl = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(xl));

            }
            else
            {
                //Error
            }
            return fxl;
        }

        public float Calcularfxu()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
            {
                fxu = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(xu));
            }
            else
            {
                //Error
            }

            return fxu;
        }

        public float Calcularfxr()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
            {
                fxr = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(xr));
            }
            else
            {

            }
            return fxr;
        }

        public float CalcularERP()
        {
           
            ERP = Math.Abs(((P - xr) / P) * 100);


            return ERP;

        }


        public float CalcularEa()
        {
           
                Ea = Math.Abs(((xr - xranterior) / xr) * 100);                                            
            return Ea;
        }

        public float Calcularfxlfxr()
        {
           fxlfxr = fxl* fxr;

            return fxlfxr;
        }

        public void Algoritmo() // Se validan las condiciones para  XU y XL
        {
            if (fxlfxr <0)
            {
                xu = xr;
                return;
            }
            if(fxlfxr > 0)
            {
                xl = xr;
                return;
            }
         
        }

       

    

    }
}
