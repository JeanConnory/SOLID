namespace SOLID._3_LSP.LSP.Violacao
{
	public class Program
	{
       private static void ObterAreaRetangulo(Retangulo ret)
		{
			Console.WriteLine("Calculo da área do Retanculo");
			Console.WriteLine(ret.Altura.ToString() + " * " + ret.Largura.ToString());
			Console.WriteLine(ret.Area);
			Console.ReadKey();
		}

		private static void Main()
		{
			var quad = new Quadrado()
			{
				Altura = 10,
				Largura = 5
			};

			ObterAreaRetangulo(quad); 
			//Aqui a classe derivada (Quadrado) tá mudando o comportamento da classe base (Retangulo) saida: 5 * 5 = 25
			// O LSP aqui é atendido mas parece ter esse bug da classe derivada alterar a classe base
		}
	}
}
