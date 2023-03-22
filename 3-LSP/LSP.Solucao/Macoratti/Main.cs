using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.LSP.Solucao.Macoratti
{
	public class Main
	{
		public void Program()
		{
			PassarosVoadores p1 = new Pato("Donald");
			p1.Comer();
			p1.BotarOvos();
			p1.Voar(); //Vem de passaros voadores

			Passaro p2 = new Pinguim("Willy");
			p2.Comer();
			p2.BotarOvos();
			//Retirado o metodo de Voar 
		}
	}
}
