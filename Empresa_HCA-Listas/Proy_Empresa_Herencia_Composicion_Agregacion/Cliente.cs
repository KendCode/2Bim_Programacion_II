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
	/// Description of Cliente.
	/// </summary>
	public class Cliente:Persona
	{
		private int nro_Cliente;
		public Cliente():base()
		{
			nro_Cliente = 10;
		}
		public void Leer(){
			base.Leer();
			Console.Write("\n-- DATOS DE CLIENTE --");
			Console.WriteLine("Ingrese nro del cliente: ");
			nro_Cliente=int.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			base.Mostrar();
			Console.Write("\n-- MOSTRANDO DATOS DE CLIENTE --");
			Console.WriteLine("\nNro de cliente= "+nro_Cliente);
		}
		public int NroClientes{
			get{return nro_Cliente;}
			set{nro_Cliente=value;}
		}
	}
}
