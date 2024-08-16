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
	/// Description of Diagnostico.
	/// </summary>
	public class Diagnostico
	{

		private int codigo;
		private string fecha;
		private Receta_Medica RM=new Receta_Medica();
		public Diagnostico()
		{
			codigo=777;
			fecha="9/10/20";
		}
		public void mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Diagnostico ---");
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Fecha= "+fecha);
			RM.Mostrar();
		}
		public int Codigo{
			get{return codigo;}
			set{codigo = value;}
		}
		public Receta_Medica RECMEDIC{
			get{return RM;}
			set{RM=value;}
		}

		
	}
}
