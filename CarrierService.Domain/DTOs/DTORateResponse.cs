using System.Text.Json.Serialization;

public class DTORateResponse
{
  [JsonPropertyName("rate")]
  public IEnumerable<DTORate> Rates { get; set; }

  public DTORateResponse()
  {
    Rates = new List<DTORate>();
  }
}