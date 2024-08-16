/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 21/05/2024
 * Hora: 20:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Camion.
	/// </summary>
	public class Camion:Vehiculo
	{
		protected double tamaño;
		//agregacion
		private Carga Ca;
		public Camion(Rueda r, Carga c):base(r){
			tamaño=12.5;
			Ca=c;
		}
		public void Leer(){
			Console.Write("\n-- DATOS DE CAMION --");
			base.Leer();
			Console.Write("Ingrese tamaño: ");
			tamaño =double.Parse(Console.ReadLine());
			Ca.Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE CAMION --");
			base.Mostrar();
			Console.WriteLine("tamaño= "+tamaño);
			Ca.Mostrar();
		}
		public double Tamano{
			get{return tamaño;}
			set{tamaño=value;}
		}
		public Carga CARGA{
			get{return Ca;}
			set{Ca=value;}
		}
	}
}
