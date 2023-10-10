namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            List<Pessoa> hospedesTemp = hospedes;
            bool capacidadeAtendida = Suite.Capacidade >= hospedesTemp.Count;

            if (capacidadeAtendida)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal resultado = DiasReservados * Suite.ValorDiaria;
            decimal valor = resultado;

            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 0.10m;
                valor -= desconto;
            }

            return valor;
        }
    }
}