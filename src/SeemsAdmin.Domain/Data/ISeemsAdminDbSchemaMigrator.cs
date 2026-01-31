using System.Threading.Tasks;

namespace SeemsAdmin.Data;

public interface ISeemsAdminDbSchemaMigrator
{
    Task MigrateAsync();
}
