using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos
{
    class ClaNomina : Form1
    {
        // atributos
        public string nombre { get; set; }
        public double sueldo { get; set; }


        // Metodos para calcular impuestos 
        public double calcularAfp(double sueldo)
        {
            double resultadoAfp = (sueldo * 2.87) / 100;
            return resultadoAfp;
        }
        public double calcularArs(double sueldo)
        {
            double resultadoArs = (sueldo * 3.04) / 100;
            return resultadoArs;
        }
        public double calculoIsr(double sueldo)
        {
            double resultadoIrs;
            if (sueldo >= 34865) { resultadoIrs = (sueldo * 3.40) / 100; }
            else { resultadoIrs = 0; }
            return resultadoIrs;
        }


        // metodos para descuento total y sueldo neto
        public string descuentoTotal()
        {
            string descuento;
            return descuento = (calcularAfp(sueldo) +calcularArs(sueldo)+calculoIsr(sueldo)).ToString();
        }
        public string sueldoNeto()
        {
            return (sueldo - double.Parse(descuentoTotal())).ToString();
        }

        


    }
}
