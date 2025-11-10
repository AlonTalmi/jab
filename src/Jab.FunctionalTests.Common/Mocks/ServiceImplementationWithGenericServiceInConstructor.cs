namespace JabTests;

internal class ServiceImplementationWithGenericServiceInConstructor : IService
{
    public ServiceImplementationWithGenericServiceInConstructor(IService<IAnotherService> genericService)
    {
        GenericService = genericService;
    }

    public IService<IAnotherService> GenericService { get; }
}