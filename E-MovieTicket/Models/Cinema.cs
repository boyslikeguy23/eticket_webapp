using System.ComponentModel.DataAnnotations;
using E_MovieTicket.Data.Base;

namespace E_MovieTicket.Models;

public class Cinema:IEntityBase
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Cinema Logo")]
    [Required(ErrorMessage = "Cinema Logo Required")]
    public string Logo { get; set; }
    
    [Display(Name = "Cinema Name")]
    [Required(ErrorMessage = "Cinema Name Required")]
    public string Name { get; set; }
    
    [Display(Name = "Description")]
    [Required(ErrorMessage = "Description Required")]
    public string Description { get; set; }
    
    //Relationship
    public List<Movie> Movies { get; set; }
}