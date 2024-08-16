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
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected string nombre;
		protected string apellido;
		protected int ci;
		protected short edad;
		protected char genero;
		protected string nacionalidad;
		protected int telefono;
		public Persona(){
			nombre="Richard";
			apellido="Perez";
			ci= 888888;
			edad= 35;
			genero= 'M';
			nacionalidad = "Bolivia";
			telefono = 12345;
		}
		public void Leer(){
			Console.Write("\n-- DATOS DE PERSONA --");
			Console.WriteLine("Ingrese nombre: ");
			nombre= Console.ReadLine();
			Console.WriteLine("Ingrese apellido: ");
			apellido= Console.ReadLine();
			Console.WriteLine("Ingrese CI: ");
			ci=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese edad: ");
			edad=short.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese genero: ");
			genero=char.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese nacionalidad: ");
			nacionalidad= Console.ReadLine();
			Console.WriteLine("Ingrese telefono: ");
			telefono=int.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.Write("\n-- MOSTRANDO DATOS DE PERSONA --");
			Console.WriteLine("\nNombre= "+nombre);
			Console.WriteLine("Apellido= "+apellido);
			Console.WriteLine("CI= "+ci);
			Console.WriteLine("Edad= "+edad);
			Console.WriteLine("Genero= "+genero);
			Console.WriteLine("Nacionalidad= "+nacionalidad);
			Console.WriteLine("Telefono= "+telefono);
		}
		public string Nombre{
			get{return nombre;}
			set{nombre = value;}
		}
		public string Apellido{
			get{return apellido;}
			set{apellido = value;}
		}
		public int Ci{
			get{return ci;}
			set{ci = value;}
		}
		public short Edad{
			get{return edad;}
			set{edad = value;}
		}
		public char Genero{
			get{return genero;}
			set{genero = value;}
		}
		public string Nacionalidad{
			get{return nacionalidad;}
			set{nacionalidad=value;}
		}
		public int Telefono{
			get{return telefono;}
			set{telefono = value;}
		}
	}
}
