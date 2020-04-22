using System;

namespace TransValida
{
    class Program
    {
		string nombre;
		int saldo;

		static void Main(string[] args)
        {

			Program persona1 = new Program();
			int c=0;
			Console.WriteLine("Sistema Experto de Transaccion Valida");
			Console.WriteLine("Edgar Escalona Escalona");
			Console.WriteLine("");
			do
			{
				string s;

				Console.WriteLine("Transaccion Valida (si/no)");
				s = Console.ReadLine();
				if (s == "si")
				{
					Console.WriteLine("Favor de ingresar su nombre completo");
					persona1.nombre = Console.ReadLine();
					Console.WriteLine("");




					int res;
					int r=0;
					do
					{
						Console.WriteLine(persona1.nombre + " ¿Qué tipo de transacción deseas realizar?");
						Console.WriteLine("");
						Console.WriteLine("1 = Retiro");
						Console.WriteLine("2 = Deposito");
						Console.WriteLine("3 = Saldo");
						Console.WriteLine("4 = Salir");

						Console.WriteLine("");


						res = int.Parse(Console.ReadLine());



						switch (res)
						{
							case 1:
								Console.WriteLine("¿Qué cantidad desea retirar?");
								int cantidad = int.Parse(Console.ReadLine());
								persona1.retiro(cantidad);
								r = 0;

								break;

							case 2:
								Console.WriteLine("¿Qué cantidad desea depositar?");
								cantidad = int.Parse(Console.ReadLine());
								persona1.deposito(cantidad);
								r = 0;
								break;

							case 3:
								
								Console.WriteLine("Saldo actual es:" + persona1.consultarSaldo(0));
								
								break;

							case 4:
								Console.WriteLine("Cerrando sesión " + persona1.nombre);
								Console.WriteLine("Puede retirar su tarjeta");
								Console.WriteLine("....");
								Console.WriteLine("Que tenga un buen día");
								r = 2;

								break;

							default:
								Console.WriteLine("Esta opción no existe");
								r = 0;
								break;

						}

					} while (r < 2);


				}
				else
				{
					Console.WriteLine("No se pudo realizar la transaccion ERROR");

				}

			} while (c != 20);


		}


		public int retiro(int cantidad)
		{
			if (saldo <= cantidad)
			{
				Console.WriteLine("Transacción invalida. Fondos insuficientes");
				Console.WriteLine("");
				return saldo;

			}
			else
			{
				Console.WriteLine("Se ha retirado la cantidad de: " + cantidad);
				saldo = saldo - cantidad;
				Console.WriteLine("Su saldo actual es de " + saldo + "$");
				Console.WriteLine("");
				return saldo;
			}

		}

		public int deposito(int cantidad)
		{
			Console.WriteLine("Se ha depositado la cantidad de: " + cantidad + "$");
			saldo = saldo + cantidad;
			Console.WriteLine("Su saldo actual es de " + saldo + "$");
			Console.WriteLine("");
			return saldo;
		}

		public int consultarSaldo(int cantidad)
		{
			return cantidad = saldo;
		}
	}
 
}
