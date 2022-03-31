using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoPorCommision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoPorComision empleado = new EmpleadoPorComision("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

			Console.WriteLine("Información del empleado obtenida por las propiedades y los métodos: \n" );
			Console.WriteLine("{0} {1}", "El primer nombre es",
			empleado.PrimerNombre);
			Console.WriteLine("{0} {1}", "El apellido es",
			empleado.ApellidoPaterno);
			Console.WriteLine("{0} {1}", "El número de seguro social es",
			empleado.NumeroSeguroSocial);
			Console.WriteLine("{0} {1:C}", "Las ventas brutas son",
			empleado.VentasBrutas);
			Console.WriteLine("{0} {1:F2}", "La tarifa de comisión es",
			empleado.TarifaComision);
			Console.WriteLine("{0} {1:C}", "Los ingresos son",
			empleado.Ingresos());

			empleado.VentasBrutas = 5000.00M; // establece las ventas brutas
			empleado.TarifaComision = .1M; // establece la tarifa de comisión

			Console.WriteLine("\n{0}:\n\n{1}",
			"Se actualizó la información del empleado obtenida por ToString", empleado);
			Console.WriteLine("ingresos: {0:C}", empleado.Ingresos());

			//Bruh


		}
    }
}
