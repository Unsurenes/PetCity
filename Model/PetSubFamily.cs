public class PetSubfamily{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PetFamilyId {get;set;}
    public virtual PetFamily? PetFamily {get;set;}
}