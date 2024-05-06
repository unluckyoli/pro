namespace pro.Repositories;

public interface IGoalRepository
{
    Task<bool> DoesAnimalExist(int id);
    Task<bool> DoesOwnerExist(int id);
    Task<bool> DoesProcedureExist(int id);
    Task<AnimalDto> GetAnimal(int id);
}