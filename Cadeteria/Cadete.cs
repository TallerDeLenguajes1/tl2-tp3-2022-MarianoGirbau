public class Cadete : Persona{

    private int PagoPedidos=300;
    public List<Pedido> Pedidos;

    public Cadete(int ID, string nombre, string direccion, long telefono, List<Pedido> Pedidos) : base(ID,nombre,direccion,telefono){
        this.Pedidos=Pedidos;
    }

    public void ListarPedidos(){
        foreach (var pedido in Pedidos)
        {
            Console.WriteLine("Numero de pedido: "+pedido.Numero);
            Console.WriteLine("Observacion: "+pedido.Obs);
            Console.WriteLine("Cliente: "+pedido.Cliente);
            Console.WriteLine("Estado: "+pedido.Estado);
        }
    }
    public int JornadaACobrar(){
        return Pedidos.Where(x => x.Estado == Pedido.EstadoPedido.Entregado).ToList().Count * PagoPedidos;
    }
}