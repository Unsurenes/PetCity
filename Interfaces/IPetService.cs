public interface IPetService{
    Task<Pet> CreatePetAsync(Pet pet);
    Task<Pet> GetPetById(int id);
    Task<IEnumerable<Pet>> GetAllPets();
    Task DeletePet(int id);
    Task<Pet> UpdatePet(int id, Pet pet);
    Task<IEnumerable<Pet>> GetPetsByName(string name);
    Task<IEnumerable<Pet>> GetPetsByGender(PetGender gender);
    Task<IEnumerable<Pet>> GetPetByPetSubfamily(PetSubfamily petSubfamily);
}