using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Solucao.Interfaces
{
	public interface IEmailServices
	{
		bool IsValid(string email);

		void Enviar(string de, string para, string assunto, string mensagem);
	}
}
