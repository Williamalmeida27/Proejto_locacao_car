namespace Entity.Models;


public record Configuracao
{
    public  int Id { get; set; }= default!;
    public string DiasDeLocacao { get; set; }= default!;
}