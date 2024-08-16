/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 16/05/2024
 * Hora: 18:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado:Persona
	{
		private double sueldo;
		private short años_Antiguedad;
		public Empleado():base()
		{
			sueldo = 1300;
			años_Antiguedad = 12;
		}
		public void Leer(){
			base.Leer();
			Console.Write("\n-- DATOS DE EMPLEADO --");
			Console.WriteLine("Ingrese sueldo de empleado: ");
			sueldo=double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese años de antiguedad del empleado: ");
			años_Antiguedad=short.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			base.Mostrar();
			Console.Write("\n-- MOSTRANDO DATOS DE EMPLEADO --");
			Console.WriteLine("\nSueldo= "+sueldo);
			Console.WriteLine("Años de Antiguedad= "+años_Antiguedad);
		}
		//propiedades
		public double Sueldo{
			get{return sueldo;}
			set{sueldo=value;}
		}
		public short AnosAntiguedad{
			get{return años_Antiguedad;}
			set{años_Antiguedad = value;}
		}
	}
}
