/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 21/05/2024
 * Hora: 20:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Garaje.
	/// </summary>
	public class Garaje
	{
		private int capacidad;
		private string horario;
		private int cant_Camiones;
		private Camion []C;
		private int cant_Vagonetas;
		private Vagoneta []V;
		public Garaje(Camion c, Vagoneta v){
			capacidad = 10;
			horario = "8:00 a 22:00";
			cant_Camiones=2;
			C = new Camion[cant_Camiones];
			for(int i=0;i<C.Length;i++)
				C[i]=c;
			cant_Vagonetas=2;
			V=new Vagoneta[cant_Vagonetas];
			for(int i=0;i<V.Length;i++)
				V[i]=v;
 		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE GARAJE --");
			Console.WriteLine("ingrese capacidad: ");
			capacidad =int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese horario: ");
			horario =Console.ReadLine();
			Console.WriteLine("Ingrese cantidad de camiones: ");
			cant_Camiones=int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Camiones;i++)
				C[i].Leer();
			Console.WriteLine("Ingrese cantidad de vagonetas: ");
			cant_Vagonetas=int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Vagonetas;i++)
				V[i].Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE GARAJE --");
			Console.WriteLine("Capacidad= "+capacidad);
			Console.WriteLine("Horario= "+horario);
			Console.WriteLine("Cantidad de Camiones= "+cant_Camiones);
			for(int i=0;i<cant_Camiones;i++)
				C[i].Mostrar();
			Console.WriteLine("Cantidad de Vagonetas= "+cant_Vagonetas);
			for(int i=0;i<cant_Vagonetas;i++)
				V[i].Mostrar();
		}
		public int Capacidad{
			get{return capacidad;}
			set{capacidad = value;}
		}
		public string Horario{
			get{return horario;}
			set{horario=value;}
		}
		public int CantCamiones{
			get{return cant_Camiones;}
			set{cant_Camiones=value;}
		}
		public Camion[] CAMION{
			get{return C;}
			set{C=value;}
		}
		public int CantVagonetas{
			get{return cant_Vagonetas;}
			set{cant_Vagonetas=value;}
		}
		public Vagoneta[] VAGONETA{
			get{return V;}
			set{V=value;}
		}
		
		
	}
}
