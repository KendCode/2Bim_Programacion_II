/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 14/05/2024
 * Hora: 20:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Rueda.
	/// </summary>
	public class Rueda
	{
		protected string marca;
		protected string modelo;
		public Rueda(){
			marca = "Goodyear";
			modelo = "DS16";
		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE RUEDA --");
			Console.WriteLine("Ingrese marca: ");
			marca=Console.ReadLine();
			Console.WriteLine("Ingrese modelo: ");
			modelo=Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE RUEDA --");
			Console.WriteLine("Marca= "+marca);
			Console.WriteLine("Modelo= "+modelo);
		}
		//atributos propios
		public string Marca{
			get{return marca;}
			set{marca=value;}
		}
		public string Modelo{
			get{return modelo;}
			set{modelo = value;}
		}
	}
}
