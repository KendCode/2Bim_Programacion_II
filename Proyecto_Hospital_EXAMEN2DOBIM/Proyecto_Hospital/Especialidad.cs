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
	/// Description of Especialidad.
	/// </summary>
	public class Especialidad
	{
		private int codigo;
		private string nombre;
		public Especialidad()
		{
			codigo=1001;
			nombre="pediatria";
		}
		public void mostrar(){
			Console.WriteLine ("--- Mostrando datos de Especialidad ---");
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Nombre= "+nombre);
		}
	}
}
