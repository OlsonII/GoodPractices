﻿namespace GoodPractices.SOLID.DependencyInversion.Bad;

public class Service
{
    private readonly Repository _repository;
    
    public Service(Repository repository)
    {
        _repository = repository;
    }
}