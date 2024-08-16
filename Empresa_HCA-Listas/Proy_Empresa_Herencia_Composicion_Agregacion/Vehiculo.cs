/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 21/05/2024
 * Hora: 20:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;


namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
	{
	
		protected string marca;
		protected string placa;
		protected short modelo;
		protected Motor Mo = new Motor();
		protected List<Rueda> Ru;
		public Vehiculo(Rueda r){
			marca = "Toyota";
			placa = "1234HCA";
			modelo = 2024;
			int cant_Ruedas = 4;
			Ru=new List<Rueda>();
			for(int i=0;i<cant_Ruedas;i++)
				Ru.Add(r);
		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE VEHICULO --");
			Console.WriteLine("Ingrese marca: ");
			marca=Console.ReadLine();
			Console.WriteLine("Ingrese placa: ");
			placa=Console.ReadLine();
			Console.WriteLine("Ingrese modelo: ");
			modelo= short.Parse(Console.ReadLine());
			Mo.Leer();
			//tipo de dato u objetos y despues quien controla
			Console.Write("\nIngrese cantidad de ruedas: ");
			int cant_ruedas=int.Parse(Console.ReadLine());
			for(int i=0; i<cant_ruedas;i++){
				Rueda rr = new Rueda();
				rr.Leer();
				Ru.Add(rr);
			}
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE VEHICULO --");
			Console.WriteLine("Marca= "+marca);
			Console.WriteLine("Placa= "+placa);
			Console.WriteLine("Modelo= "+modelo);
			Mo.Mostrar();
			Console.WriteLine("Cantidad de ruedas= "+Ru.Count);
			foreach(Rueda R in Ru)
				R.Mostrar();
		}
		//PROPIEDADES DE LOS ATRIBUTOS PROPIOS DE LA CLASE
		public string Marca{
			get{return marca;}
			set{marca =value;}
		}
		public string Placa{
			get{return placa;}
			set{marca =value;}
		}
		public short Modelo{
			get{return modelo;}
			set{modelo =value;}
		}
		
		//PROPIEDADES DE LOS ATRIBUTOS OBJETOS O OBJETOS ARRAY
		public Motor MOTOR{
			get{return Mo;}
			set{Mo=value;}
		}
		public List<Rueda> RUEDAS{
			get{return Ru;}
			set{Ru=value;}
		}
	}
}

