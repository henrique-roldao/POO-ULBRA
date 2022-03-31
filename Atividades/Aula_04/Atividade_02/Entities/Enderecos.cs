namespace Atividade_02.Entities
{
    public class Endereco
    {
        public Endereco(int cep, string nomeDaRua, int numeroResidencia, string bairro)
        {
            CEP = cep;
            NomeDaRua = nomeDaRua;
            NumeroResidencia = numeroResidencia;
            Bairro = bairro;
        }

        public int CEP { get; set; }
        public string NomeDaRua { get; set; }
        public int NumeroResidencia { get; set; }
        public string Bairro { get; set; }
        public Cliente Cliente { get; set; }

    }
}