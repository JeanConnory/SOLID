using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.LSP.Solucao.Macoratti
{
	public class Pato : PassarosVoadores
	{
		public Pato(string nome) : base(nome)
		{
		}

		public override void Comer()
		{
			Console.WriteLine($"\n {Nome} come milho...");
		}

		public override void BotarOvos()
		{
			Console.WriteLine($"\n {Nome} bota 6 ovos...");
		}

		public override void Voar()
		{
			Console.WriteLine($"\n {Nome} voa baixo...");
		}
	}
}
