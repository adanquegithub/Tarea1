using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoPorCommision
{
    public class EmpleadoBaseMasComision
    {
		private string primerNombre;
		private string apellidoPaterno;
		private string numeroSeguroSocial;
		private decimal ventasBrutas; // ventas semanales totales
		private decimal tarifaComision; // porcentaje de comisión
		private decimal salarioBase; // salario base por semana

				// constructor con seis parámetros
		public EmpleadoBaseMasComision( string nombre, string apellido,
		string nss, decimal ventas, decimal tarifa, decimal salario )
		{
				// la llamada implícita al constructor del objeto se realiza aquí
			primerNombre = nombre;
			apellidoPaterno = apellido;
			numeroSeguroSocial = nss;
			VentasBrutas = ventas; // valida las ventas brutas a través de una propiedad
			TarifaComision = tarifa; // valida la tarifa de comisión a través de una
					//propiedad
			SalarioBase = salario; // valida el salario base a través de una propiedad
		} // fin del constructor de EmpleadoBaseMasComision con seis parámetros

				// propiedad de sólo lectura que obtiene
				// el primer nombre del empleado por comisión con salario base
		public string PrimerNombre
		{
			get
			{
				return primerNombre;
			} // fin de get
		}
		public string ApellidoPaterno
        {
            get
            {
				return apellidoPaterno;
            }
        }
		public string NumeroSeguroSocial
        {
            get
            {
				return numeroSeguroSocial;
            }
        }
		public decimal VentasBrutas
        {
			get
            {
				return ventasBrutas;
            }
            set
            {
				ventasBrutas = (value < 0) ? 0 : value;
			}
        }
		public decimal TarifaComision
        {
            get
            {
				return tarifaComision;
            }
            set
            {
				tarifaComision = (value > 0 && value < 1) ? value : 0;
			}
        }
		public decimal SalarioBase
        {
            get
            {
				return salarioBase;
            }
            set
            {
				salarioBase = (value < 0) ? 0 : value;
            }
        }
		public decimal Ingresos
        {
            get
            {
				return SalarioBase + (TarifaComision * VentasBrutas);
            }
        }
		public override string ToString()
        {
			return String.Format(
				"{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
				"empleado por comisión con salario base", PrimerNombre, ApellidoPaterno,
				"número de seguro social", NumeroSeguroSocial,
				"ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision,
				"salario base", SalarioBase
				);
        }
    }
}
