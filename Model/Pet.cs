public class Pet
{   
    public Pet(){}
    public Pet(PetDTO petDTO){
        this.Name = petDTO.Name;
        this.BirthDate = petDTO.BirthDate;
        this.PetImageUrl = petDTO.PetImageUrl;
        this.PetGender = petDTO.PetGender;
        this.PetFamily = petDTO.PetFamily;
        this.PetSubfamily = petDTO.PetSubfamily;
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string? PetImageUrl { get; set; }
    public int PetGenderId { get; set; }
    public int PetFamilyId { get; set; }
    public int PetSubfamilyId { get; set; }
    public PetGender? PetGender { get; set; }
    public PetFamily? PetFamily { get; set; }
    public PetSubfamily? PetSubfamily { get; set; }

}