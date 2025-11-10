namespace Jab;

internal record ExistingCallSite : ServiceCallSite
{
    public ExistingCallSite(ServiceIdentity identity, ITypeSymbol serviceType, ServiceCallSite target)
        : base(identity, serviceType, target.Lifetime, target.IsDisposable)
    {
        Target = target;
    }

    public ServiceCallSite Target { get; }
}
