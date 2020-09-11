using OrchardCore.ContentManagement.Metadata;
using OrchardCore.Data.Migration;
using System.Threading.Tasks;
using OrchardCore.Recipes.Services;

namespace OrchardSkills.OrchardCore.OpenIDConnect
{
    public class Migrations : DataMigration
    {
        private readonly IRecipeMigrator _recipeMigrator;

        public Migrations(IContentDefinitionManager contentDefinitionManager,
            IRecipeMigrator recipeMigrator
            )
        {
            _recipeMigrator = recipeMigrator;
        }

        public int Create()
        {
            return 1;
        }
        public async Task<int> UpdateFrom1Async()
        {
            await _recipeMigrator.ExecuteAsync("api-role.json", this);

            return 2;
        }

        public async Task<int> UpdateFrom2Async()
        {
            await _recipeMigrator.ExecuteAsync("sql-alias-query.json", this);

            return 3;
        }

        public async Task<int> UpdateFrom3Async()
        {
            await _recipeMigrator.ExecuteAsync("openid.json", this);

            return 3;
        }
    }
}