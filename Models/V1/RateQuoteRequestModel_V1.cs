namespace ca.speedy.my
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RateQuoteRequestModel_V1 
    {
        [Newtonsoft.Json.JsonProperty("shipperCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShipperCity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipperPostalZip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShipperPostalZip { get; set; }
    
        [Newtonsoft.Json.JsonProperty("consigneeCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConsigneeCity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("consigneePostalZip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConsigneePostalZip { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pieces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RateQuoteRequestPieceModel_V1> Pieces { get; set; }
    
    
    }
}