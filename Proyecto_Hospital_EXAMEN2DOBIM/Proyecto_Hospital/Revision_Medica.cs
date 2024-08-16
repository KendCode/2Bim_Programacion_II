/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 17:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Revision_Medica.
	/// </summary>
	public class Revision_Medica
	{
		private int codigo;
		private string fecha;
		private Diagnostico DG=new Diagnostico();
		public Revision_Medica()
		{
			codigo=555;
			fecha="10/10/20";
		}
		public void mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Revisión Medica ---");
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Fecha= "+fecha);
			DG.mostrar();
		}
		public Diagnostico DIAGNOSTICO{
			get{return DG;}
			set{DG=value;}
		}
		public string Fecha{
			get{return fecha;}
			set{fecha=value;}
		}
	}
}
