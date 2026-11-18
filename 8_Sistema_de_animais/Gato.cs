
namespace ExerciciosPilaresPOO
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine("Som: Miau!\n");
        }
    }
}