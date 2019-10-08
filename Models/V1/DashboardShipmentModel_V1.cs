namespace ca.speedy.my
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DashboardShipmentModel_V1 
    {
        [Newtonsoft.Json.JsonProperty("movementType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MovementType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pickupConfirmationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PickupConfirmationCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bol { get; set; }
    
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Quantity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("quantityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuantityType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("weightLbs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? WeightLbs { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipmentStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShipmentStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("etautc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Etautc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipper", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 Shipper { get; set; }
    
        [Newtonsoft.Json.JsonProperty("consignee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 Consignee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currentLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GeoLocationModel_V1 CurrentLocation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("trackShipmentEntries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DashboardShipmentEntryModel_V1> TrackShipmentEntries { get; set; }
    
    
    }
}