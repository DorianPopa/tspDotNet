using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace MyPhotos
{
    public class DatabaseContext
    {
        private static DatabaseModelContainer Context;

        public static DatabaseModelContainer GetContext()
        {
            if(Context == null)
                Context = new DatabaseModelContainer();
            return Context;
        }
    }
}
