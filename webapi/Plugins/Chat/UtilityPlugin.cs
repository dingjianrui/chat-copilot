using System;
using System.ComponentModel;
using System.Text.Json;
using CopilotChat.WebApi.Storage;
using Microsoft.SemanticKernel;
namespace CopilotChat.WebApi.Plugins.Chat;

#pragma warning disable IDE0055
public sealed class UtilityPlugin
{
    HealthReportRepository _repository;
    string[] UserId = new string[] { "CN7865990", "CN7906474", "CN8171781", "CN8058667", "CN7552115", "CN8546480", "CN5879383", "CN7860099", "CN8067836", "CN7869566" };
    public UtilityPlugin(HealthReportRepository repository)
    {
      this._repository = repository;
    }

    [KernelFunction]
    [Description("Utiltiy functions used by other plugins.")]
    public string Find([Description("userId")] string userId)
    {
      int index = new Random().Next(0, 9);
      string result = string.Empty;

      if (index % 2 == 0)
      {
        var id = this.UserId[index];
        var report = this._repository.FindByIdAsync(id, id).Result;
        result = JsonSerializer.Serialize(report);
        if (result.Length > 3072) 
        { 
          result = result.Substring(0, 3072); 
        }
      }
      else
      {
        result = "没有找到";
      }
      return result;
    }
}

#pragma warning disable IDE0055