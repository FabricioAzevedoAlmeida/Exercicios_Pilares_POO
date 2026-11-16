
namespace ExerciciosPilaresPOO
{
       public class NotificacaoSMS : Notificacao
    {
        public NotificacaoSMS(string destinatario, string mensagem) : base(destinatario, mensagem) { }

        public override void Enviar()
        {
            Console.WriteLine($"SMS: Enviando torpedo para o número {Destinatario}: {Mensagem}");
        }
    }
}