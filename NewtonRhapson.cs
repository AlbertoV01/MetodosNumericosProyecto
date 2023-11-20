using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;
namespace Métodos_Numéricos_401
{
    public class NewtonRhapson
    {
        public NewtonRhapson(string funcion, float ximas1, string funcionderivada, float p) 
        {
            this.funcion = funcion;
            this.ximas1 = ximas1;
            this.funcionderivada=funcionderivada; 
            this.p = p;
        }

        //public NetwonRhapson(float xianterior)
        //{
        //    this.xianterior = xianterior;

        //}

        public string funcion;
        public string funcionderivada;
        public float ximas1;
        public float fximas1;
        public float derivadafxmas1;
        public float erp;
        public float ea;
        public float extra;
        private float p;
        public float xianterior;

        Calculo AnalizadorDeFunciones = new Calculo();

       public float CalcularXi()
        {
            if(extra==0)
            {
                fximas1 = 0;
                derivadafxmas1 = 1;
                extra=extra+1;
            }
            ximas1 = ximas1 - (fximas1 / derivadafxmas1);
            return ximas1;
        }

        public float Calcularfxi()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion,'x'))
            {
                fximas1 = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(ximas1));
            }
            else
            {
            }
            return fximas1;      
        }

        public float Calcularfxiderivada()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcionderivada, 'x'))
            {
                derivadafxmas1 = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(ximas1));
            }
            else
            {
            }
            return derivadafxmas1;
        }

        public float CalcularERP()
        {
            erp = Math.Abs((p - ximas1) /p)*100;
            return erp;
        }
        
        public float CalcularEa(float xianterior)
        {
            ea = Math.Abs((ximas1 - xianterior) / ximas1) * 100;
            return ea;
        }

}
    } 
