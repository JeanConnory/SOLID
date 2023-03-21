namespace SOLID._2_OCP.OCP.Solucao
{
	internal class DebitoContaCorrente : DebitoConta
	{
		public override string Debitar(decimal valor, string conta)
		{
			// Debita conta corrente
			return NumeroTransacao;
		}
	}
}