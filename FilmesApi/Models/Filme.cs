using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O t�tulo do filme � obrigat�rio")]
    public string Titulo {get;set;}
    [Required(ErrorMessage = "O g�nero do filme � obrigat�rio")]
    [MaxLength(50, ErrorMessage = "O tamanho do g�nero n�o pode exceder 50 caracteres")]
    public string Genero {get;set;}
    [Required]
    [Range(70, 600, ErrorMessage = "A dura��o deve ter entre 70 e 600 minutos")]
    public int Duracao {get;set;}
}