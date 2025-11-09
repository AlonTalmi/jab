namespace Jab;

internal record ResolveDelegateCallSite : ServiceCallSite
{
    public ResolveDelegateCallSite(ServiceIdentity identity, ITypeSymbol resolvedType, bool usesName)
        : base(identity, identity.Type, ServiceLifetime.Transient, false)
    {
        ResolvedType = resolvedType;
        UsesName = usesName;
    }

    public ITypeSymbol ResolvedType { get; }
    public bool UsesName { get; }
}
