/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 17:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Medicamento.
	/// </summary>
	public class Medicamento
	{
		private int codigo;
		private string nombre;
		private string fecha;
		public Medicamento()
		{
			codigo=890;
			nombre="Paracetamol";
			fecha="12/10/23";
		}
		public void Mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Medicamento ---");
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Fecha= "+fecha);
		}
		public string Nombre{
			get{return nombre;}
			set{nombre = value;}
		}
		public int Codigo{
			get{return codigo;}
			set{codigo=value;}
		}
	}
}
