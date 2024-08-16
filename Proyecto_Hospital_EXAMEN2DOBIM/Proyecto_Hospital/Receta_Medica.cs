/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 17:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Receta_Medica.
	/// </summary>
	public class Receta_Medica
	{
		private int codigo;
		private string fecha;
		private int cant_med;
		private Medicamento[]M;
		public Receta_Medica()
		{
			codigo=333;
			fecha="3/5/23";
			cant_med=2;
			M=new Medicamento[cant_med];
			for(int i=0;i<cant_med;i++)
				M[i]=new Medicamento();
		}
		public void Mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Receta Medica ---");
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Fecha= "+fecha);
			Console.WriteLine("\nCantidad de medicamentos= "+cant_med);
			for(int i=0;i<cant_med;i++)
				M[i].Mostrar();
		}
		public int CantMedicamentos{
			get{return cant_med;}
			set{cant_med=value;}
		}
		public Medicamento[] MEDICAMENTO{
			get{return M;}
			set{M=value;}
		}
		public int Codigo{
			get{return codigo;}
			set{codigo=value;}
		}
		
	}
}
