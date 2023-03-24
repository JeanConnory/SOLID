namespace SOLID._5_DIP.DIP.Violacao
{
	public class ClienteService
	{
		public string AdicionarCliente(Cliente cliente)
		{
			if (!cliente.IsValid())
				return "Dados Inválidos";

			var repo = new ClienteRepository();
			repo.AdicionarCliente(cliente);

			EmailService.Enviar("empresa@empresa.com", cliente.Email, "Bem vindo", "Parabéns está cadastrado");

			return "Cliente cadastrado com sucesso";
		}
	}
}
