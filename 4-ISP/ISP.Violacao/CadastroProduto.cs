using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.ISP.Violacao
{
	internal class CadastroProduto : ICadastroCliente
	{
		public void ValidarDados()
		{
			// Validar Valor
		}

		public void SalvarBanco()
		{
			// Insert na tabela Produto
		}

		public void EnviarEmail()
		{
			// Produto não tem e-mail, o que eu faço agora???
		}
	}
}
