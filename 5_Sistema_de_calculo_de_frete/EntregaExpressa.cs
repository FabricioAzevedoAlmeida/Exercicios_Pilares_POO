
namespace ExerciciosPilaresPOO
{
    class EntregaExpressa : Entrega
    {
        public override double CalcularFrete()
        {
            return (Distancia * 2.0) + 10.0;
        }
    }

}