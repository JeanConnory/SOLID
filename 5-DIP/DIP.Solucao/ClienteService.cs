using SOLID._5_DIP.DIP.Solucao.Interfaces;

namespace SOLID._5_DIP.DIP.Solucao
{
	public class ClienteService : IClienteServices
	{
		private readonly IClienteRepository _clienteRepository;
		private readonly IEmailServices _emailServices;

        public ClienteService(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
			_clienteRepository = clienteRepository;
			_emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
		{
			if (!cliente.IsValid())
				return "Dados Inválidos";

			_clienteRepository.AdicionarCliente(cliente);			

			_emailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem vindo", "Parabéns está cadastrado");

			return "Cliente cadastrado com sucesso";
		}
	}
}
