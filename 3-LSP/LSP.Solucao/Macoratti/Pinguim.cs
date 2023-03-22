using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.LSP.Solucao.Macoratti
{
	public class Pinguim : Passaro
	{
		public Pinguim(string nome) : base(nome)
		{
		}

		public override void Comer()
		{
			Console.WriteLine($"\n {Nome} come peixes...");
		}

		public override void BotarOvos()
		{
			Console.WriteLine($"\n {Nome} bota 2 ovos...");
		}
	}
}
