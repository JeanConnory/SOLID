namespace SOLID._3_LSP.LSP.Violacao
{
	internal class Quadrado : Retangulo
	{
		public override double Altura 
		{ 
			set => base.Altura = base.Largura = value; 
		}

		public override double Largura
		{
			set => base.Altura = base.Largura = value;
		}
	}
}
