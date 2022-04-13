public interface IPetGenderRepository
{
    Task<PetGender> AddPetGender(PetGender petGender);
    Task<PetGender> UptadePetGender(int id, PetGender petGender);
    Task DeletePetGender(int id);
    Task<IEnumerable<PetGender>> GetAllPetGenders();
    Task<PetGender> GetPetGenderById(int id);
}