using System.Threading.Tasks;

namespace VNEmsAdmin.Data;

public interface IVNEmsAdminDbSchemaMigrator
{
    Task MigrateAsync();
}
