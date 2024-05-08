using System.ComponentModel.DataAnnotations;

namespace up1.Models;

public class Userinfo
{
    [Key]
    public int Id { get; set; }
   
    public required string Name {get; set;}

    public int Gpa {get; set;}
    public DateTime CreatedDateTime {get; set; } = DateTime.Now;



    
}