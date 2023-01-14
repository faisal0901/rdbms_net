using rdbms_net.repositories;

namespace Tokonyadia.Repositories;

public class DbPersisttence:IPersisttence
{
    private readonly TokonyadiaContext _tokonyadiaContext;

    public DbPersisttence(TokonyadiaContext tokonyadiaContext)
    {
        _tokonyadiaContext = tokonyadiaContext;
    }
    public void SaveChanges()
    {
        _tokonyadiaContext.SaveChanges(); 
    }
}