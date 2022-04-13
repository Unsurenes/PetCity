public interface IPetRepository{
    Task<Pet> CreatePetAsync(Pet pet);
    Task<Pet> GetPetById(int id);
    Task<IEnumerable<Pet>> GetAllPets();
    Task DeletePet(int id);
    Task<Pet> UpdatePet(Pet pet);
    Task<IEnumerable<Pet>> GetPetsByName(string name);
    Task<IEnumerable<Pet>> GetPetsByGender(PetGender gender);
    Task<IEnumerable<Pet>> GetPetsByPetSubfamily(PetSubfamily petSubfamily);
   

}