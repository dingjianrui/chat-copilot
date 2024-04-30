using System.ComponentModel;
using System.Text.Json;
using CopilotChat.WebApi.Storage;
using Microsoft.SemanticKernel;
namespace CopilotChat.WebApi.Plugins.Chat;

#pragma warning disable IDE0055
public sealed class HealthcarePlugin
{
    HealthReportRepository _repository;
    public HealthcarePlugin(HealthReportRepository repository)
    {
      this._repository = repository;
    }

    [KernelFunction]
    [Description("个人健康报告查询")]
    public string FindHealthReport([Description("用户ID")] string userId)
    {
      var report = this._repository.FindByIdAsync("CN7865990", "女").Result;
      string result = "没有找到健康报告，请先完成健康报告";
      if (report != null)
      {
        result = JsonSerializer.Serialize(report);
      }
      if(result.Length > 3072)
      {
        result = result.Substring(0, 2072);
      }
      return result;
    }
}

#pragma warning disable IDE0055