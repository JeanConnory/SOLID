namespace SOLID._2_OCP.OCP.ExtensionMethod
{
	internal static class DebitoContaCorrente
	{
		public static string DebitarContaCorrente(this DebitoConta debitoConta)
		{
			//Lógica debitar conta corrente
			//Pode pegar o campo valor, conta e etc
			return debitoConta.FormatarTransacao();
		}
	}
}
