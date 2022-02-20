namespace TaxCalculation.WebAPI.Settings
{
    public class TaxJarApiOptions
    {
        public const string TaxJarApi = "TaxJarApi";

        public string TaxesEndpoint { get; set; } = string.Empty;
        public string RatesEndpoint { get; set; } = string.Empty;
    }
}
