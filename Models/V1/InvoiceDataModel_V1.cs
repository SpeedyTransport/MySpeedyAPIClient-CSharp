namespace ca.speedy.my
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InvoiceDataModel_V1 
    {
        [Newtonsoft.Json.JsonProperty("stNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("masterPro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MasterPro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("consolidationMasterPro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConsolidationMasterPro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("invoiceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("summaryNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SummaryNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("batchNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BatchNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("billTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BillTo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("invoiceDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? InvoiceDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("agentPro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgentPro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("totalCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalCharge { get; set; }
    
        [Newtonsoft.Json.JsonProperty("freightCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FreightCharge { get; set; }
    
        [Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Weight { get; set; }
    
        [Newtonsoft.Json.JsonProperty("netWeight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NetWeight { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cubeWeight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CubeWeight { get; set; }
    
        [Newtonsoft.Json.JsonProperty("asWeight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AsWeight { get; set; }
    
        [Newtonsoft.Json.JsonProperty("consolidatedPros", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ConsolidatedPros { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pallets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pallets { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pieces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pieces { get; set; }
    
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remark { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fuelSurchargePct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FuelSurchargePct { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fuelSurchargeVal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FuelSurchargeVal { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Hst { get; set; }
    
        [Newtonsoft.Json.JsonProperty("gst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gst { get; set; }
    
        [Newtonsoft.Json.JsonProperty("qst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Qst { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Tax { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deliveryTrailer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryTrailer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipperAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 ShipperAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("consigneeAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 ConsigneeAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("billToAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 BillToAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("accessorials", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AccessorialModel_V1> Accessorials { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipmentPieces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ShipmentPieceModel_V1> ShipmentPieces { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pOs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<POModel_V1> POs { get; set; }
    
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("loadId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LoadIdModel_V1 LoadId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bol { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unitOfMeasure", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitOfMeasure { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }
    
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Comments { get; set; }
    
        [Newtonsoft.Json.JsonProperty("packagingType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PackagingType { get; set; }
    
    
    }
}