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
	/// Description of Paciente.
	/// </summary>
	public class Paciente:Persona
	{
		private string fecha_internacion;
		private Revision_Medica RM=new Revision_Medica();
		public Paciente():base()
		{
			fecha_internacion="4/5/22";
		}
		public void Mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Paciente ---");
			base.mostrar();
			Console.WriteLine("Fecha de internación= "+fecha_internacion);
			RM.mostrar();
		}
		public Revision_Medica REVISIOMEDIC{
			get{return RM;}
			set{RM=value;}
		}
		 
	}
}
