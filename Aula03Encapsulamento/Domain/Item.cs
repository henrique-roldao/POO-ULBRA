namespace Aula03Encapsulamento.Domain
{
    public class Item
    {
        public int id { get; private set; }
        public string Nome { get; private set; }
        public Mochila Mochila { get; set; }

        public Item(int id, string nome)
        {
            this.id = id;
            this.Nome = nome;
        }
    }
}