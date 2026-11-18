
namespace ExerciciosPilaresPOO
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine("Som: Au au!\n");
        }
    }
}