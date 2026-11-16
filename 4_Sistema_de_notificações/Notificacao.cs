
namespace ExerciciosPilaresPOO
{
    public class Notificacao
    {
        public string Destinatario { get; set; }
        public string Mensagem { get; set; }

        public Notificacao(string destinatario, string mensagem)
        {
            Destinatario = destinatario;
            Mensagem = mensagem;
        }

        public virtual void Enviar()
        {
            Console.WriteLine($"Notificação Genérica: Enviando para {Destinatario}: {Mensagem}");
        }
    }
}