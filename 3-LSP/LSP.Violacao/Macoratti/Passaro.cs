using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.LSP.Violacao.Macoratti
{
	public class Passaro
	{
        public string Nome { get; set; }

        public Passaro(string nome)
        {
            Nome = nome;
        }

        public virtual void Comer()
        {
            Console.WriteLine($"\n {Nome} comendo...");
        }

		public virtual void BotarOvos()
		{
			Console.WriteLine($"\n {Nome} bota ovos...");
		}

		public virtual void Voar()
		{
			Console.WriteLine($"\n {Nome} voando...");
		}
	}
}
