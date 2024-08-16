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
		//a)1ra forma
		public void buscarVagoneta(){
			Console.Write("\n Ingrese placa de la vagoneta a buscar: ");
			string x = Console.ReadLine().ToLower();
			for (int i=0;i<g.getCantVagonetas();i++){
				if(g.getVAGONETA()[i].getPlaca().ToLower().Equals(x)){
					Console.WriteLine("Ingrese nuevo modelo: ");
					g.getVAGONETA()[i].setModelo(short.Parse(Console.ReadLine()));
					g.getVAGONETA()[i].Mostrar();
				}
			}
		}
		//a)2da forma
		public void buscarVagoneta3(){
			g.buscarvagoneta2();
		}
		//b) 1ra forma
		public void cambiarAmbiente(){
			Console.Write("\nIngrese ambiente de la carga a buscar: ");
			string x = Console.ReadLine().ToLower();
			for(int i=0; i<g.getCantCamionetas();i++){
				if(g.getCAMION()[i].getCARGA().getAmbiente().ToLower().Equals(x)){
					Console.Write("\nIngrese nuevo ambiente: ");
					string aux=Console.ReadLine();
					g.getCAMION()[i].getCARGA().setAmbiente(aux);
					g.getCAMION()[i].getCARGA().Mostrar();
				}
			}
		}
		//2da forma
		public void cambiarAmbiente4(){
			g.cambiarAmbiente3();
		}
		//c) 1ra forma
		public void modificarModelo(){
			Console.Write("\nIngrese potencia a buscar: ");
			double x= double.Parse(Console.ReadLine());
			for(int i=0;i<g.getCantVagonetas();i++){
				if(g.getVAGONETA()[i].getMOTOR().getPotencia().Equals(x)){
					Console.Write("Ingrese nuevo modelo: ");
					g.getVAGONETA()[i].getMOTOR().setModelo(Console.ReadLine());
					g.getVAGONETA()[i].getMOTOR().Mostrar();
				}
			}
		}
		//c) 2da forma
		public void modificarModelo4(){
			g.modificarModelo3();
		}
	
		//D) PRIMERA FORMA
		public void BuscarVehiculo(){
			Console.Write("\nPlaca de vehiculo a buscar: ");
			string x = Console.ReadLine().ToLower();
			for(int i=0; i<g.getCantVagonetas();i++){
				if(g.getVAGONETA()[i].getPlaca().ToLower().Equals(x)){
					Console.Write("Ingrese nuevo modelo de motor: ");
					g.getVAGONETA()[i].getMOTOR().setModelo(Console.ReadLine());
					Console.Write("Ingrese nuevo modelo del vehiculo: ");
					g.getVAGONETA()[i].setModelo(short.Parse(Console.ReadLine()));
					g.getVAGONETA()[i].Mostrar();
				}
			}
			for(int i=0; i<g.getCantCamionetas();i++){
				if(g.getCAMION()[i].getPlaca().ToLower().Equals(x)){
					Console.Write("Ingrese nuevo modelo de motor: ");
					g.getCAMION()[i].getMOTOR().setModelo(Console.ReadLine());
					Console.Write("Ingrese nuevo modelo del vehiculo: ");
					g.getCAMION()[i].setModelo(short.Parse(Console.ReadLine()));
					g.getCAMION()[i].Mostrar();
				}
			}
		}
		//D) SEGUNDA FORMA
		public void BuscarVehiculo4(){
			g.BuscarVehiculo3();
		}
		//E) PRIMER FORMA
		public void BuscarGenero(){
			Console.Write("\nIngrese genero a buscar: ");
			char x = char.Parse(Console.ReadLine());
			int contG =0;
			for(int i=0; i<cant_Admi;i++)
				if(Ad[i].getGenero().ToString().ToLower().Equals(x.ToString().ToLower()))
					contG++;
			for(int i=0; i<cant_Op;i++)
				if(Op[i].getGenero().ToString().ToLower().Equals(x.ToString().ToLower()))
					contG++;
			for(int i=0; i<cant_cli;i++)
				if(Cli[i].getGenero().ToString().ToLower().Equals(x.ToString().ToLower()))
					contG++;
			if(x.ToString().ToLower().Equals("f"))
				Console.WriteLine("\nLa cantidad de genero femenino es:"+contG);
			else
				Console.WriteLine("\nLa cantidad de genero masculino es: "+contG);
		}
		//E)SEGUNDA FORMA
		public void BuscarGenero2(){
			Console.Write("\nIngrese genero a contabilizar: ");
			char x = char.Parse(Console.ReadLine());
			int contG =0;
			for(int i=0; i<cant_Admi;i++)
				contG=Ad[i].BuscarGenero1(x,contG);
			for(int i=0; i<cant_Op;i++)
				contG=Op[i].BuscarGenero1(x,contG);
			for(int i=0; i<cant_cli;i++)
				contG=Cli[i].BuscarGenero1(x,contG);
			if(x.ToString().ToLower().Equals("f"))
				Console.WriteLine("\nLa cantidad de genero femenino es:"+contG);
			else
				Console.WriteLine("\nLa cantidad de genero masculino es: "+contG);
		}
		
		//F) PRIMERA FORMA
		public void BuscarRueda(){
			Console.Write("\nIngrese marca de la rueda a buscar: ");
			string x = Console.ReadLine();
			for(int i=0; i<g.getCantCamionetas();i++){
				for(int j=0; j<g.getCAMION()[i].getCantRuedas();j++){
					if(g.getCAMION()[i].getRUEDA()[j].getMarca().ToLower().Equals(x)){
						Console.Write("\nIngrese nuevo modelo de la rueda: ");
						g.getCAMION()[i].getRUEDA()[j].setModelo(Console.ReadLine());
						g.getCAMION()[i].getRUEDA()[j].Mostrar();
					}
				}
			}
		}
		
		//F SEGUNDA FORMA
		public void BuscarRueda4(){
			g.BuscarRueda3();
		}
		
		//G) PRIMERA FORMA
		public void BuscarEmpleado(){
			Console.Write("\nIngrese nacionalidad del empleado a buscar: ");
			string x = Console.ReadLine().ToLower();
			for(int i=0; i<cant_Admi;i++){
				if(Ad[i].getNacionalidad().ToLower().Equals(x)){
					Ad[i].setSueldo(Ad[i].getSueldo()+Ad[i].getSueldo()*0.15);
					Ad[i].Mostrar();
				}
			}
			for(int i=0; i<cant_Op;i++){
				if(Op[i].getNacionalidad().ToLower().Equals(x)){
					Op[i].setSueldo(Op[i].getSueldo()+Op[i].getSueldo()*0.15);
					Op[i].Mostrar();
				}
			}
		}
		//G) 2 FORMA
		public void BuscarEmpleado2(){
			Console.Write("\nIngrese nacionalidad del empleado a buscar: ");
			string x = Console.ReadLine();
			for(int i=0; i<cant_Admi;i++)
				Ad[i].BuscarEmpleado1(x);
			for(int i=0; i<cant_Op;i++)
				Op[i].BuscarEmpleado1(x);
			
		}
		
		//h) PRIMERA FORMA
		public void CambioHoraCapa(){
			Console.Write("\nIngrese la nueva hora: ");
			string x = Console.ReadLine();
			g.setHorario(x);
			Console.Write("\nIngrese la nueva capacidad: ");
			int z = int.Parse(Console.ReadLine());
			g.setCapacidad(z);
			g.Mostrar();
		}
		//H ) 2DA FORMA
		public void CambioHoraCapa2(){
			g.CambioHoraCapa1();
		}
		
		//I) PRIMERA FORMA
		public void BuscarModeloMotorPeso(){
			Console.Write("\nIngrese modelo del motor A BUSCAR: ");
			string x = Console.ReadLine();
			Console.Write("\nIngrese peso del vehiculo a buscar: ");
			double y= double.Parse(Console.ReadLine());
			for(int i=0; i<g.getCantCamionetas();i++){
				if(g.getCAMION()[i].getMOTOR().getModelo().ToLower().Equals(x) && g.getCAMION()[i].getMOTOR().getPeso().Equals(y)){
						Console.Write("\nIngrese nueva marca del vehiculo: ");
						g.getCAMION()[i].setMarca(Console.ReadLine());
						g.getCAMION()[i].Mostrar();		
				}
			}
			for(int i=0; i<g.getCantVagonetas();i++){
				if(g.getVAGONETA()[i].getMOTOR().getModelo().ToLower().Equals(x) && g.getVAGONETA()[i].getMOTOR().getPeso().Equals(y)){
						Console.Write("\nIngrese nueva marca del vehiculo: ");
						g.getVAGONETA()[i].setMarca(Console.ReadLine());
						g.getVAGONETA()[i].Mostrar();		
				}
			}
		}
		//i) SEGUNFDA FORMA
		public void CambiarMarca4(){
			g.CambiarMarca3();
		}
		
	}
}
