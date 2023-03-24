using SOLID._5_DIP.DIP.Solucao.Interfaces;

namespace SOLID._5_DIP.DIP.Solucao
{
	public class CPFService : ICPFServices
	{
		public bool IsValid(string cpf)
		{
			return cpf.Length == 11;
		}
	}
}
