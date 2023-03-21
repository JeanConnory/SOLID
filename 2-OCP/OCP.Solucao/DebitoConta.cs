namespace SOLID._2_OCP.OCP.Solucao
{
	internal abstract class DebitoConta
	{
		public string NumeroTransacao { get; set; }

		public abstract string Debitar(decimal valor, string conta);
	}
}
