﻿namespace SOLID._1_SRP.SRP.Solucao
{
	public static class CPFService
	{
		public static bool IsValid(string cpf)
		{
			return cpf.Length == 11;
		}
	}
}
