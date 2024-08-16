/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 14/05/2024
 * Hora: 20:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Carga.
	/// </summary>
	public class Carga
	{
		private string tipo;
		private string ambiente;
		public Carga(){
			tipo = "mercaderia";
			ambiente = "frio";
		}
		public void Leer(){
			Console.Write("\n-- DATOS CARGA --");
			Console.Write("Ingrese tipo: ");
			tipo = Console.ReadLine();
			Console.Write("Ingrese ambiente: ");
			ambiente = Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE CARGA --");
			Console.WriteLine("Tipo= "+tipo);
			Console.WriteLine("Ambiente= "+ambiente);
		}
		public string Tipo{
			get{return tipo;}
			set{tipo=value;}
		}
		public string Ambiente{
			get{return ambiente;}
			set{ambiente = value;}
		}
	}
}
