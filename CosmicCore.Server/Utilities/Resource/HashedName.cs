namespace CosmicCore.Server.Utilities.Resource;

public class HashedName
{
    public string Hash { get; set; }

    public static implicit operator long(HashedName? name)
    {
        return name is not null ? Convert.ToInt64(name.Hash) : -1;
    }
}
