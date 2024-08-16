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
	/// Description of Doctor.
	/// </summary>
	public class Doctor:Persona
	{
		private int codigo;
		private short años_servicio;
		private string area;
		Especialidad E =new Especialidad();
		public Doctor():base()
		{
			codigo=101010;
			años_servicio=5;
			area="pediatria";
		}
		public void mostrar(){
			Console.WriteLine("\n---Mostrando datos de Doctor ---");
			base.mostrar();
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Años de servicio= "+años_servicio);
			Console.WriteLine("Area= "+area);
		}
		
	}
}
