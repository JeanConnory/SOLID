namespace SOLID._2_OCP.OCP.ExtensionMethod
{
	public class Pessoa
	{
        public string Nome { get; set; }

		public string Sobrenome { get; set; }

		public string FormatarNome()
		{
			return Nome + " " + Sobrenome;
		}
    }

	public static class ExtensionPessoa // Tem que ser estático
	{
		public static int NomeLength(this Pessoa pessoa) //this aqui
		{
			return pessoa.FormatarNome().Length;
		}
	}

	public class Main //Simulando o metodo Main
	{
		public int TestarExtension()
		{
			var pessoa = new Pessoa()
			{
				Nome = "Jean",
				Sobrenome = "Michael"
			};

			return pessoa.NomeLength(); // Metodo de extensão

			//Console.WriteLine(pessoa.NomeLength());
		}
	}
}
