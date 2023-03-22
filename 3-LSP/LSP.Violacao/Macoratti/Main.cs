using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LSP.LSP.Violacao.Macoratti
{
	public class Main
	{
		public void Program()
		{
			Passaro p1 = new Pato("Donald");
			p1.Comer();
			p1.BotarOvos();
			p1.Voar();

			Passaro p2 = new Pinguim("Willy");
			p2.Comer();
			p2.BotarOvos();
			p2.Voar(); //Lança a exceção pq pinguim não voa e altera o comportamento da classe base (Passaro).
		}
	}	
}
