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
	/// Description of Motor.
	/// </summary>
	public class Motor
	{
		protected string modelo;
		protected double peso;
		protected double potencia;
		public Motor(){
			modelo="F10A";
			peso=350;//en kg
			potencia=50;
		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE MOTOR --");
			Console.Write("Ingrese modelo: ");
			modelo=Console.ReadLine();
			Console.Write("Ingrese peso en kg: ");
			peso=double.Parse(Console.ReadLine());
			Console.Write("Ingrese potencia: ");
			potencia=double.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE MOTOR --");
			Console.WriteLine("Modelo= "+modelo);
			Console.WriteLine("Peso= "+peso+" Kg");
			Console.WriteLine("Potencia= "+potencia+" RPM");
		}
		public string Modelo{
			get{return modelo;}
			set{modelo=value;}
		}
		public double Peso{
			get{return peso;}
			set{peso=value;}
		}
		public double Potencia{
			get{return potencia;}
			set{potencia=value;}
		}
	}
}
