
namespace ExerciciosPilaresPOO
{
    public class NotificacaoPush : Notificacao
    {
        public NotificacaoPush(string destinatario, string mensagem) : base(destinatario, mensagem) { }

        public override void Enviar()
        {
            Console.WriteLine($"Push: Alerta no aplicativo para o usuário {Destinatario}: {Mensagem}");
        }
    }
}