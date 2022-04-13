public interface IPetFamilyRepository{
    Task<IEnumerable <PetFamily>> GetAllPetFamilies();
    Task<PetFamily> GetPetFamilyByName(string Name);
    Task<PetFamily> AddPetFamily(PetFamily petFamily);
    Task<PetFamily> UpdatePetFamily(int id, PetFamily petFamily);
    Task <PetFamily> GetPetFamilyById(int id);
    Task DeletePetFamily(int id);
}