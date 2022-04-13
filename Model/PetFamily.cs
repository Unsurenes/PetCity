public class PetFamily{
    public int Id { get; set; }
    public string? Name { get; set; }
    public virtual ICollection <PetSubfamily>? PetSubfamily {get;set;}
 
}