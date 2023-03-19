using System.Net.Mail;

namespace SOLID._1_SRP.SRP.Solucao
{
	public static class EmailService
	{
		public static bool IsValid(string email)
		{
			return email.Contains("@");
		}

		public static void Enviar(string de, string para, string assunto, string mensagem)
		{
			var mail = new MailMessage(de, para);
			var client = new SmtpClient
			{
				Port = 25,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Host = "smtp.empresa.com"
			};

			mail.Subject = "Bem vindo";
			mail.Body = "Parabéns! Você está cadastrado";
			client.Send(mail);
		}
	}
}
