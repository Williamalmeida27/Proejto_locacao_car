namespace Entity.Models;

public record Carro
{
    
    public  int Id { get; set; }  = default!;
    public string Nome { get; set; }  = default!;
    public int MarcaId { get; set; } = default!;
    public Marca? Marca {get; set;}
    public int ModeloId { get; set; } = default!;
    public Modelo? Modelo {get; set;}
}