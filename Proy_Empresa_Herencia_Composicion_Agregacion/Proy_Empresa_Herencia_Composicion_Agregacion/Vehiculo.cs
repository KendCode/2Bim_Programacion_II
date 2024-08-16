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
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
	{
	
		protected string marca;
		protected string placa;
		protected short modelo;
		private Motor Mo = new Motor();
		protected short cant_Ruedas;
		private Rueda []Ru;
		public Vehiculo(Rueda r){
			marca = "Toyota";
			placa = "1234HCA";
			modelo = 2024;
			cant_Ruedas = 4;
			Ru=new Rueda[cant_Ruedas];
			for(int i=0;i<cant_Ruedas;i++)
				Ru[i]=r;
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
			Console.WriteLine("Ingrese cantidad de ruedas: ");
			cant_Ruedas= short.Parse(Console.ReadLine());
			for (int i=0; i<cant_Ruedas;i++)
				Ru[i].Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE VEHICULO --");
			Console.WriteLine("Marca= "+marca);
			Console.WriteLine("Placa= "+placa);
			Console.WriteLine("Modelo= "+modelo);
			Mo.Mostrar();
			Console.WriteLine("Cantidad de ruedas= "+cant_Ruedas);
			for (int i=0; i<cant_Ruedas;i++)
				Ru[i].Mostrar();
		}
		public string getMarca(){
			return marca;
		}
		public void setMarca(string marca){
			this.marca = marca;
		}
		public string getPlaca(){
			return placa;
		}
		public void setPlaca(string placa){
			this.placa = placa;
		}
		public short getModelo(){
			return modelo;
		}
		public void setModelo(short modelo){
			this.modelo = modelo;
		}
		//retornar el objeto motor
		public Motor getMOTOR(){
			return Mo;
		}
		public void setMOTOR(Motor Mo){
			this.Mo=Mo;
		}
		public short getCantRuedas(){
			return cant_Ruedas;
		}
		public void setCantRuedas(short cant_Ruedas){
			this.cant_Ruedas = cant_Ruedas;
		}
		//retornar el objeto rueda
		public Rueda[] getRUEDA(){
			return Ru;
		}
		public void setRUEDA(Rueda[] Ru){
			this.Ru=Ru;
		}
		//C) 2da forma
		public void modificarModelo2(double x){
			Mo.modificarModelo1(x);
		}
		public void cambiarModelo2(){
			Console.Write("\nIngrese nuevo modelo: ");
			modelo = short.Parse(Console.ReadLine());
			Mostrar();
		}
		//D)SEGUNDA FORMA
		public void BuscarVehiculo2(string x){
			if(placa.ToUpper().Equals(x.ToUpper())){
				Mo.BuscarVehiculo1();
				Console.Write("\nNuevo modelo de vehiculo: ");
				modelo = short.Parse(Console.ReadLine());
				Mostrar();
			}
		}
		
		//f) RUEDA DOS
		public void BuscarRueda2(string x){
			for(int i=0; i<cant_Ruedas;i++)
				Ru[i].BuscarRueda1(x);
		}
		//i 2da forma
		public void CambiarMarca2(string x, double y){
			if(Mo.CambiarMarca1(x,y)){
				Console.Write("\nIngrese nueva marca: ");
				marca = Console.ReadLine();
				Mostrar();
				Console.WriteLine();
			}
		}
	}
}

