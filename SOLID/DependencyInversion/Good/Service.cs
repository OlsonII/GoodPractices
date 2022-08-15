namespace GoodPractices.SOLID.DependencyInversion.Good;

public class Service
{
    private readonly IRepository _repository;
    
    public Service(IRepository repository)
    {
        _repository = repository;
    }
}