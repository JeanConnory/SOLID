namespace SOLID._2_OCP.OCP.Violacao
{
	internal class DebitoConta //Internal mesmo assembly
	{
		public void Debitar(decimal valor, string conta, TipoConta tipoConta)
		{
			if(tipoConta == TipoConta.Corrente)
			{
				// Debita conta corrente
			}

			if(tipoConta == TipoConta.Poupanca)
			{
				// Valida aniversário da conta
				// Debita Conta Poupança
			}
		}
	}
}
