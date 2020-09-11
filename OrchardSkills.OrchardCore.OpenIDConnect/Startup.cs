using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Data.Migration;

namespace OrchardSkills.OrchardCore.OpenIDConnect
{

    public class Startup : StartupBase
    {

        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDataMigration, Migrations>();
        }
    }
}
