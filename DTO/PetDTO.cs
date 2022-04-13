public class PetDTO
{
    public PetDTO() { }
    public PetDTO(Pet pet)
    {   
        this.Id = pet.Id;
        this.Name = pet.Name;
        this.BirthDate = pet.BirthDate;
        this.PetFamily = pet.PetFamily;
        this.PetSubfamily = pet.PetSubfamily;
        this.PetGender = pet.PetGender;
        this.PetImageUrl = pet.PetImageUrl;
    }
    
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string? PetImageUrl { get; set; }
    public PetGender? PetGender { get; set; }
    public PetFamily? PetFamily { get; set; }
    public PetSubfamily? PetSubfamily { get; set; }

}