using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;
public class HealthReportRepository : Repository<HealthReport>
{
  public HealthReportRepository(IStorageContext<HealthReport> storageContext)
      : base(storageContext)
  {
  }
}