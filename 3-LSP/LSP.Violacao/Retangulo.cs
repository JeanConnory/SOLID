﻿namespace SOLID._3_LSP.LSP.Violacao
{
	internal class Retangulo
	{
		public virtual double Altura { get; set; }

		public virtual double Largura { get; set; }

		public double Area { get { return Altura * Largura; } }
	}
}
