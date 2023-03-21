namespace SOLID._2_OCP.OCP.ExtensionMethod
{
	internal static class DebitoContaInvestimento
	{
		public static string DebitarContaInvestimento(this DebitoConta debitoConta)
		{
			// Inserir taxas
			// Lógica debitar conta investimento
			return debitoConta.FormatarTransacao();
		}
	}
}
