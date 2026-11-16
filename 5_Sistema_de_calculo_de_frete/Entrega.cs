
namespace ExerciciosPilaresPOO
{
    abstract class Entrega
    {
        public double Distancia { get; set; }
        public abstract double CalcularFrete();
    }
}