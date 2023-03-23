using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.ISP.Violacao
{
	internal class CadastroCliente : ICadastro
	{
		public void ValidarDados()
		{
			// Validar CPF, Email
		}

		public void SalvarBanco()
		{
			// Insert na tabela Cliente
		}

		public void EnviarEmail()
		{
			// Enviar e-mail para o cliente
		}
	}
}
