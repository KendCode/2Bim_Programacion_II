/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 14/05/2024
 * Hora: 20:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Persona P = new Persona();
			Cliente C= new Cliente();
			Empleado EM = new Empleado();
			Operario O = new Operario();
			Administrativo A = new Administrativo();
			
			Carga CAR = new Carga();
			Rueda RU = new Rueda();
			Motor MO = new Motor();
			
			Vehiculo V = new Vehiculo(RU);
			Camion CA = new Camion(RU,CAR);
			Vagoneta VA = new Vagoneta(RU);
			
			Garaje G = new Garaje(CA,VA);
			
			Empresa E = new Empresa(A,O,C);
			E.Mostrar();
			//E.Leer();
			//E.Mostrar();
			
			
			//b) BUSCAR LA CARGA DE TIPOI"X" MODIFICAR SU AMBIENTE
			//LISTAS 1RA FORMA
			E.BuscarCarga();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}