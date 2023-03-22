using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.LSP.Solucao.Macoratti
{
	public class PassarosVoadores : Passaro
	{
        public PassarosVoadores(string nome) : base(nome)
        {            
        }

		public virtual void Voar()
		{
			Console.WriteLine($"\n {Nome} voando...");
		}
	}
}
