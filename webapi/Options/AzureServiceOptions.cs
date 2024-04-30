namespace CopilotChat.WebApi.Options;

#pragma warning disable IDE0055
/// <summary>
/// Options for the Azure Service.
/// </summary>
/// <remarks>
public class AzureServiceOptions
{
  public AzureServiceOptions()
  {
        this.SignalR = new AzureSignalROptions();
  }
  /// <summary>
  /// The Azure Service endpoint.
  /// </summary>
  public AzureSignalROptions? SignalR { get; set; }
  /// <summary>
  /// The Azure SingnalR Service.
  /// </summary>
  public class AzureSignalROptions
  {
    /// <summary>
    /// The Azure SignalR Service endpoint.
    /// </summary>
    public string? ConnectionString { get; set; }
  }
}