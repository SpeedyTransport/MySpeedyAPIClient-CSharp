namespace ca.speedy.my
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RateQuoteModel_V1 
    {
        [Newtonsoft.Json.JsonProperty("accTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AccTotal { get; set; }
    
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }
    
        [Newtonsoft.Json.JsonProperty("surcharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Surcharge { get; set; }
    
        [Newtonsoft.Json.JsonProperty("commodityCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommodityCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unitOfMeasure", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitOfMeasure { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("gst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gst { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Hst { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Pst { get; set; }
    
        [Newtonsoft.Json.JsonProperty("qst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Qst { get; set; }
    
        [Newtonsoft.Json.JsonProperty("discount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Discount { get; set; }
    
    
    }
}