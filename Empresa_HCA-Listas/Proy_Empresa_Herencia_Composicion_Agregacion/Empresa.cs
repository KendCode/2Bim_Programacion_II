/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 21/05/2024
 * Hora: 20:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		private string nombre;
		private string direccion;
		private long nit;
		private List<Administrativo> Ad;
		private List<Operario> Op;
		private List<Cliente> Cli;
		
		private Garaje g;
		
		public Empresa(Administrativo a, Operario o, Cliente c){
			nombre="ABC";
			direccion="Av. Circunvalacion";
			nit=123456;
			
			int cant_Admi=2;
			Ad=new List<Administrativo>();
			for(int i=0;i<cant_Admi;i++)
				Ad.Add(a);
			
			int cant_Op=1;
			Op = new List<Operario>();
			for(int i=0;i<cant_Op;i++)
				Op.Add(o);
			
			int cant_cli=3;
			Cli=new List<Cliente>();
			for(int i=0;i<cant_cli;i++)
				Cli.Add(c);
			
			Rueda ru = new Rueda();
		 	Carga car = new Carga();
		 	Camion ca = new Camion(ru,car);
			Vagoneta va = new Vagoneta(ru);
			g = new Garaje(ca,va);
		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE EMPRESA --");
			Console.Write("Ingrese nombre de la empresa: ");
			nombre=Console.ReadLine();
			Console.Write("Ingrese direccion: ");
			direccion=Console.ReadLine();
			Console.Write("Ingrese nit: ");
			nit=long.Parse(Console.ReadLine());
			Console.Write("Ingrese cantiad de administrativos: ");
			int cant_Admi=int.Parse(Console.ReadLine());
			Console.Write("Ingrese cantidad de operarios: ");
			int cant_Op=int.Parse(Console.ReadLine());
			Console.Write("Ingrese cantidad de clientes: ");
			int cant_cli=int.Parse(Console.ReadLine());
			
			for(int i=0;i<cant_Admi;i++){
				Administrativo a = new Administrativo();
				a.Leer();
				Ad.Add(a);
			}
				
			Console.WriteLine("Cant de Operarios: ");
			for(int i=0;i<cant_Op;i++){
				Operario o = new Operario();
				o.Leer();
				Op.Add(o);
			}
			Console.WriteLine("Cant de Clientes: ");
			for(int i=0;i<cant_cli;i++){
				Cliente c = new Cliente();
				c.Leer();
				Cli.Add(c);
			}
				
		}
		public void Mostrar(){
			Console.WriteLine("\n--MOSTRANDO DATOS DE EMPRESA --");
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Direccion= "+direccion);
			Console.WriteLine("NIT= "+nit);
			Console.WriteLine("Cant de Administrativos= "+Ad.Count);
			foreach(Administrativo AA in Ad)
				AA.Mostrar();
			Console.WriteLine("Cant de Operarios= "+Op.Count);
			foreach(Operario OO in Op)
				OO.Mostrar();
			Console.WriteLine("Cant de Clientes= "+Cli.Count);
			foreach(Cliente CC in Cli)
				CC.Mostrar();
			g.Mostrar();
		}
		public string Nombre{
			get{return nombre;}
			set{nombre=value;}
		}
		public string Direccion{
			get{return direccion;}
			set{direccion=value;}
		}
		public long Nit{
			get{return nit;}
			set{nit = value;}
		}
		
		public List<Administrativo> ADMIN{
			get{return Ad;}
			set{Ad = value;}
		}
		public List<Operario> OPERARIO{
			get{return Op;}
			set{Op=value;}
		}
		
		public List<Cliente> CLIENTE{
			get{return Cli;}
			set{Cli=value;}
		}
		public Garaje GARAJE{
			get{return g;}
			set{g=value;}
		}
		public void BuscarCarga(){
			Console.Write("\nIngrese tipo de carga a buscar: ");
			string x = Console.ReadLine().ToLower();
			foreach(Camion A in g.CAMION){
				if(A.CARGA.Tipo.ToLower().Equals(x)){
					Console.Write("\nIngrese nuevo ambiente: ");
					A.CARGA.Ambiente=Console.ReadLine();
					A.CARGA.Mostrar();
				}
			}
			
		}
		
	}
}
