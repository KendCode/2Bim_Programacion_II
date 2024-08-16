/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 19:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Hospital.
	/// </summary>
	public class Hospital
	{
		private string nombre;
		private string direccion;
		private int telefono;
		private int cant_doc;
		private int cant_pa;
		private Doctor[] Doc;
		private Paciente[] Pa;
		public Hospital(Doctor d, Paciente p)
		{
			nombre = "San Juan XX";
			direccion = "Villa integracion";
			telefono = 2343434;
			cant_doc = 2;
			cant_pa = 3;
			Doc = new Doctor[cant_doc];
			Pa = new Paciente[cant_pa];
			for (int i = 0; i < cant_doc; i++)
				Doc[i] = d;
			for (int i = 0; i < cant_pa; i++)
				Pa[i] = p;
		}
		public void Mostrar()
		{
			Console.WriteLine("\n--- Mostrando datos de HOSPITAL ---");
			Console.WriteLine("Nombre= " + nombre);
			Console.WriteLine("Direccion= " + direccion);
			Console.WriteLine("Telefono= " + telefono);
			Console.WriteLine("Cantidad de Doctores= " + cant_doc);
			for (int i = 0; i < cant_doc; i++)
				Doc[i].mostrar();
			Console.WriteLine("Cantidad de Pacientes= " + cant_pa);
			for (int i = 0; i < cant_pa; i++)
				Pa[i].mostrar();
		}
		public int CantDoc {
			get{ return cant_doc; }
			set{ cant_doc = value; }
		}
		public Doctor[] DOCTOR {
			get{ return Doc; }
			set{ Doc = value; }
		}
		public int CantPac {
			get{ return cant_pa; }
			set{ cant_pa = value; }
		}
		public Paciente[] PACIENTE {
			get{ return Pa; }
			set{ Pa = value; }
		}
		//A
		public void BuscarPaciente()
		{
			Console.Write("\nIngrese CI a buscar: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("\n Ingrese Codigo de diagnostico: ");
			int y = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < CantPac; i++) {
				if (PACIENTE[i].Ci.Equals(x) && PACIENTE[i].REVISIOMEDIC.DIAGNOSTICO.Codigo.Equals(y)) {
					for (int j = 0; j < PACIENTE[i].REVISIOMEDIC.DIAGNOSTICO.RECMEDIC.CantMedicamentos; j++) {
						Pa[j].REVISIOMEDIC.DIAGNOSTICO.RECMEDIC.MEDICAMENTO[j].Mostrar();
					}
					
				}
			}
			
		}
		public void ModificarCeluDirec2(){
			Console.Write("\nIngrese nombre a buscar: ");
			string x = Console.ReadLine();
			
		}
		//C
		public void BuscarRevisionPaciente()
		{
			Console.Write("\nIngrese Fecha de revision medica: ");
			string x = Console.ReadLine();
			for (int i = 0; i < cant_pa; i++) {
				if (PACIENTE[i].REVISIOMEDIC.Fecha.Equals(x)) {
					Console.Write("Ingrese nuevo Codigo de diagnostico: ");
					PACIENTE[i].REVISIOMEDIC.DIAGNOSTICO.Codigo=int.Parse(Console.ReadLine());
					Console.Write("Ingrese nuevo Codigo de receta medica: ");
					int z = int.Parse(Console.ReadLine());
					PACIENTE[i].REVISIOMEDIC.DIAGNOSTICO.RECMEDIC.Codigo=z;
					Mostrar();
					
				}
				
			}
		}
	}
}
