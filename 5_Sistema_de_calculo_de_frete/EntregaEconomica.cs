
namespace ExerciciosPilaresPOO
{
    class EntregaEconomica : Entrega
    {
        public override double CalcularFrete()
        {
            return Distancia * 1.0; 
        }
    }
}