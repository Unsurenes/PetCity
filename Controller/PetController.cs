using Microsoft.AspNetCore.Mvc;
namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;
    public PetController(IPetService petService)
    {
        this._petService = petService; 
    }
    
    [HttpPost]
    public async Task<Pet> Create(Pet pet)
    {
        return await _petService.CreatePetAsync(pet);
    }

    [HttpGet]
    public async Task<IEnumerable<Pet>> GetAllPets()
    {
       return await _petService.GetAllPets();
    }

    [HttpGet("getbyname")]
    public async Task<IEnumerable<Pet>> GetPetsByName([FromQuery]string name)
    {
        return await _petService.GetPetsByName(name);
    }

    [HttpGet("getbygender")]
    public async Task<IEnumerable<Pet>> GetPetsByGender([FromBody]PetGender gender)
    {
        return await _petService.GetPetsByGender(gender);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _petService.DeletePet(id);
    }

    [HttpPut]
    public async Task Update(int id, Pet pet)
    {
        await _petService.UpdatePet(id, pet);
    }
}