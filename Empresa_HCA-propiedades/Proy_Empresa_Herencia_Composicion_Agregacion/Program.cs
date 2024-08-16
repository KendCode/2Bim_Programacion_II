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
			
			
			//B)Busacar la carga con ambiente "x", modificar el tipos de carga
			//1RA FORMA PROPIEDADES
			//E.BuscarCarga();
			
			
			
			
			
			//c)Buscar el motor de la vagoneta de potencia "x" y modificar su modelo
			
			
			//D)ente LOS VEHICULOS BUSCAR LA PLACA "X" MODIFICAR EL MODELO motor y DEL VEHICULO MOSTRAR DATOS ACTULIZADOS
			
			
			//E)¿CUANTAS PERSONAS SON DE GENERO "X"?
			
			
			//F) DE LA VAGONETA BUSCAR LA MARCA DE LA  RUEDA "X" Y MODIFICAR EL MODELO DE SU RUEDA
			//E.CambiarMoeloR();
			
			
			
			
			
			//G) ENTRE LOS EMPLEADOS BUSCAR AQUELLOS QUE TENGAN MAS DE "X" AÑOS DE ANTIGUEDAD, MODIFICAR SU SUELDO MAS UN 5% 
			//Y MODIFICAR su telefono, mostrar datos actualizados
			E.ModificarEmpleado();
			
			
			
			
			
			
			//h) CAMBIAR EL HORARIO Y CAPACIDAD DEL GARAJE 
			
			
			
			
			//i) ENTRE LOS VEHICULOS BUSCAR EL MODELO DEL MOTOR "X" Y PESO "Y", 
			//MODIFICAR LA MARCA DEL VEHICULO . MOSTARR DATOS ACTUALIZADOS
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}