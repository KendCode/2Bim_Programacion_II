/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 21/05/2024
 * Hora: 20:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

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
		private int cant_Admi;
		private Administrativo []Ad;
		private int cant_Op;
		private Operario []Op;
		private int cant_cli;
		private Cliente []Cli;
		
		private Garaje g;
		
		public Empresa(Administrativo a, Operario o, Cliente c){
			nombre="ABC";
			direccion="Av. Circunvalacion";
			nit=123456;
			
			cant_Admi=2;
			Ad=new Administrativo[cant_Admi];
			for(int i=0;i<cant_Admi;i++)
				Ad[i]=a;
			
			cant_Op=1;
			Op = new Operario[cant_Op];
			for(int i=0;i<cant_Op;i++)
				Op[i]=o;
			
			cant_cli=3;
			Cli=new Cliente[cant_cli];
			for(int i=0;i<cant_cli;i++)
				Cli[i]=c;
			
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
			cant_Admi=int.Parse(Console.ReadLine());
			Console.Write("Ingrese cantidad de operarios: ");
			cant_Op=int.Parse(Console.ReadLine());
			Console.Write("Ingrese cantidad de clientes: ");
			cant_cli=int.Parse(Console.ReadLine());
			
			for(int i=0;i<cant_Admi;i++)
				Ad[i].Leer();
			Console.WriteLine("Cant de Operarios: ");
			for(int i=0;i<cant_Op;i++)
				Op[i].Leer();
			Console.WriteLine("Cant de Clientes: ");
			for(int i=0;i<cant_cli;i++)
				Cli[i].Leer();
			g.Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n--MOSTRANDO DATOS DE EMPRESA --");
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Direccion= "+direccion);
			Console.WriteLine("NIT= "+nit);
			Console.WriteLine("Cant de Administrativos= "+cant_Admi);
			for(int i=0;i<cant_Admi;i++)
				Ad[i].Mostrar();
			Console.WriteLine("Cant de Operarios= "+cant_Op);
			for(int i=0;i<cant_Op;i++)
				Op[i].Mostrar();
			Console.WriteLine("Cant de Clientes= "+cant_cli);
			for(int i=0;i<cant_cli;i++)
				Cli[i].Mostrar();
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
		public int CantAdmin{
			get{return cant_Admi;}
			set{cant_Admi = value;}
		}
		public Administrativo[] ADMIN{
			get{return Ad;}
			set{Ad = value;}
		}
		public int CantOperarios{
			get{return cant_Op;}
			set{cant_Op=value;}
		}
		public Operario[] OPERARIO{
			get{return Op;}
			set{Op=value;}
		}
		public int CantClientes{
			get{return cant_cli;}
			set{cant_cli=value;}
		}
		public Cliente[] CLIENTE{
			get{return Cli;}
			set{Cli=value;}
		}
		public Garaje GARAJE{
			get{return g;}
			set{g=value;}
		}
		//clase todo
		//B)UTILIZANDO PROPIEDADES 1RA FORMA
		public void BuscarCarga(){
			Console.Write("\nIngrese Ambiente de la carga a buscar; ");
			string x = Console.ReadLine().ToLower();
			for(int i=0; i<g.CantCamiones;i++){
				if(g.CAMION[i].CARGA.Ambiente.ToLower().Equals(x)){
					Console.Write("\nIngrese nuevo tipo de carga: ");
					g.CAMION[i].CARGA.Tipo=Console.ReadLine();
					g.CAMION[i].CARGA.Mostrar();
				}
			}
		}
		//F)PROPIEDADES 1ra forma
		public void CambiarMoeloR(){
			Console.Write("\nIngrese marca de la rueda a buscar: ");
			string x= Console.ReadLine();
			for(int i=0; i<g.CantVagonetas;i++){
				for(int j=0; j<g.VAGONETA[i].CantRuedas;i++){
					if(g.VAGONETA[i].RUEDAS[j].Marca.ToUpper().Equals(x.ToUpper())){
						Console.Write("\nIngrese nuevo modelo de rueda: ");
						g.VAGONETA[i].RUEDAS[j].Modelo=Console.ReadLine();
						g.VAGONETA[i].RUEDAS[j].Mostrar();
					}
				}
			}
		}
		//G) 1RA FORMA PRO
		public void ModificarEmpleado(){
			Console.Write("\nIngrese años de antiguedad: ");
			short x = short.Parse(Console.ReadLine());
			for(int i=0; i<cant_Admi;i++){
				if(Ad[i].AnosAntiguedad>x){
					Ad[i].Sueldo=Ad[i].Sueldo+Ad[i].Sueldo*0.08;
					Console.Write("\nIngrese nuevo telefono: ");
					Ad[i].Telefono=int.Parse(Console.ReadLine());
					Ad[i].Mostrar();
				}
			}
			for(int i=0; i<cant_Op;i++){
				if(Op[i].AnosAntiguedad>x){
					Op[i].Sueldo=Op[i].Sueldo+Op[i].Sueldo*0.08;
					Console.Write("\nIngrese nuevo telefono: ");
					Op[i].Telefono=int.Parse(Console.ReadLine());
					Op[i].Mostrar();
				}
			}
		}
	}
}
