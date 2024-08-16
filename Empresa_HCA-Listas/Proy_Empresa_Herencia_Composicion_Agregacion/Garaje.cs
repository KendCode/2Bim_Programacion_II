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
	/// Description of Garaje.
	/// </summary>
	public class Garaje
	{
		private int capacidad;
		private string horario;
		private List<Camion> C;
		private List<Vagoneta> V;
		public Garaje(Camion c, Vagoneta v){
			capacidad = 10;
			horario = "8:00 a 22:00";
			int cant_Camiones=2;
			C = new List<Camion>();
			for(int i=0;i<cant_Camiones;i++)
				C.Add(c);
			int cant_Vagonetas=2;
			V=new List<Vagoneta>();
			for(int i=0;i<cant_Vagonetas;i++)
				V.Add(v);
 		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE GARAJE --");
			Console.WriteLine("ingrese capacidad: ");
			capacidad =int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese horario: ");
			horario =Console.ReadLine();
			Console.WriteLine("Ingrese cantidad de camiones: ");
			int cant_Camiones=int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Camiones;i++){
				Rueda rr = new Rueda();
				Carga ca = new Carga();
				Camion cc= new Camion(rr,ca);
				cc.Leer();
				C.Add(cc);
			}
				
			Console.WriteLine("Ingrese cantidad de vagonetas: ");
			int cant_Vagonetas=int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Vagonetas;i++){
				Rueda rr = new Rueda();
				Carga ca = new Carga();
				Vagoneta v= new Vagoneta(rr);
				v.Leer();
				V.Add(v);
			}
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE GARAJE --");
			Console.WriteLine("Capacidad= "+capacidad);
			Console.WriteLine("Horario= "+horario);
			Console.WriteLine("Cantidad de Camiones= "+C.Count);
			foreach(Camion CC in C)
				CC.Mostrar();
			Console.WriteLine("Cantidad de Vagonetas= "+V.Count);
			foreach(Vagoneta W in V)
				W.Mostrar();
		}
		public int Capacidad{
			get{return capacidad;}
			set{capacidad = value;}
		}
		public string Horario{
			get{return horario;}
			set{horario=value;}
		}
		
		public List<Camion> CAMION{
			get{return C;}
			set{C=value;}
		}
		
		public List<Vagoneta> VAGONETA{
			get{return V;}
			set{V=value;}
		}
		
		
	}
}
