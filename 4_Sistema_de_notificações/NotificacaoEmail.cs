
namespace ExerciciosPilaresPOO
{
     public class NotificacaoEmail : Notificacao
    {
        public NotificacaoEmail(string destinatario, string mensagem) : base(destinatario, mensagem) {}

        public override void Enviar()
        {
            Console.WriteLine($"E-mail: Enviando e-mail para {Destinatario} com o conteúdo: \"{Mensagem}\"");
        }
    }
}