
namespace LanchoneteMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<Produto> Itens { get; set; }
    }
}
