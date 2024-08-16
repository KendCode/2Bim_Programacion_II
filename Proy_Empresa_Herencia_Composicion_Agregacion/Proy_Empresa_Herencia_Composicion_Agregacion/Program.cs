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
			
			
			//a) Busacar a la vagoneta con placa "x" modificar su modelo 
			//1ra forma (get y set)
			//E.buscarVagoneta();
			//2da forma
			//E.buscarVagoneta3();
			
			//b)Busacar la carga con ambiente "x" modificar por uno nuevo
			//1ra forma
			//E.cambiarAmbiente();
			//2da forma
			//E.cambiarAmbiente4();
			
			//c)Buscar el motor de la vagoneta de potencia "x" y modificar su modelo
			//1ra forma
			//E.modificarModelo();
			//2da forma
			
			//D)ente LOS VEHICULOS BUSCAR LA PLACA "X" MODIFICAR EL MODELO motor y DEL VEHICULO MOSTRAR DATOS ACTULIZADOS
			//E.BuscarVehiculo();
			//E.BuscarVehiculo4();
			
			//E)¿CUANTAS PERSONAS SON DE GENERO "X"?
			//E.BuscarGenero();
			//2da FORMA
			//E.BuscarGenero2();
			
			//F) DEL CAMION BUSCAR MARCA DE LA RUEDA "X" Y MODIFICAR EL MODELO DE SU RUEDA
			//FORMA 1
			//E.BuscarRueda();
			//FORMA 2
			//E.BuscarRueda4();
			
			//G) ENTRE LOS EMPLEADOS BUSCAR AQUELLOS DE DE NACIONALIDAD "X", MODIFICAR 
			//SU SUELDO MAS UN 15% MOSTRAR DATOS ACTUALIZADOS
			//E.BuscarEmpleado();
			//2forma
			//E.BuscarEmpleado2();
			
			//h) CAMBIAR EL HORARIO Y CAPACIDAD DEL GARAJE 
			//1RA FORMA
			//E.CambioHoraCapa();
			//2DA FORMA
			//E.CambioHoraCapa2();
			
			
			
			//i) ENTRE LOS VEHICULOS BUSCAR EL MODELO DEL MOTOR "X" Y PESO "Y", 
			//MODIFICAR LA MARCA DEL VEHICULO . MOSTARR DATOS ACTUALIZADOS
			//1RA FORMA
			//E.BuscarModeloMotorPeso();
			//2DA FORMA
			E.CambiarMarca4();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}