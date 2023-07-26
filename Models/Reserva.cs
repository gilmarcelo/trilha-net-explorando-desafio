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
            
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("capacidade não suporta o número de hospedes");
                    
                 
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
                     
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
         
            decimal valor = DiasReservados * Suite.ValorDiaria;

           
            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 0.10m;
                valor -= desconto;
            }

            return valor;
        }
    }
}