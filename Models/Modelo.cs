namespace Entity.Models;

public record Modelo
{

    public  int Id { get; set; }= default!;
    public string Nome { get; set; }= default!;

    public int MarcaId { get; set; } = default!;
    public Marca? Marca {get; set;} 

}