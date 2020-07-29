namespace E_Commerce
{
    public partial class Startup
    {
        //Classe para alimentar o banco de dados com o catalogo inicial dos produtos e garantir que tenha sido criado
        class DataService : IDataService
        {
            private readonly ApplicationContext context;

            public DataService(ApplicationContext context)
            {
                this.context = context;
            }

            public void InicializaDB()
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
