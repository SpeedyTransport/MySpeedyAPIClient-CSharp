namespace ca.speedy.my
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ShipmentTripModel_V1 
    {
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("trip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Trip { get; set; }
    
        [Newtonsoft.Json.JsonProperty("powerUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PowerUnit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("trailer1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Trailer1 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("trailer2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Trailer2 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("locations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ShipmentLocationModel_V1> Locations { get; set; }
    
    
    }
}