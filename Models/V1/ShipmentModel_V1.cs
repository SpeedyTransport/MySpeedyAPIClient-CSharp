namespace ca.speedy.my
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ShipmentModel_V1 
    {
        [Newtonsoft.Json.JsonProperty("pro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("advancedPro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdvancedPro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("beyondPro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BeyondPro { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pickupConfirmationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PickupConfirmationCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bol { get; set; }
    
        [Newtonsoft.Json.JsonProperty("loadId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("billTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BillTo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pOs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> POs { get; set; }
    
        [Newtonsoft.Json.JsonProperty("startDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("endDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("entries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ShipmentEntryModel_V1> Entries { get; set; }
    
        [Newtonsoft.Json.JsonProperty("trips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ShipmentTripModel_V1> Trips { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currentLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ShipmentLocationModel_V1 CurrentLocation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("etautc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Etautc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("createdDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CreatedDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("updatedDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipperAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 ShipperAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("consigneeAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 ConsigneeAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("thirdPartyAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AddressModel_V1 ThirdPartyAddress { get; set; }
    
        [Newtonsoft.Json.JsonProperty("receiverName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReceiverName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Quantity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("quantityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuantityType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("weightLbs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? WeightLbs { get; set; }
    
        [Newtonsoft.Json.JsonProperty("appointmentFromDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AppointmentFromDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("appointmentToDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AppointmentToDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("locationOpenDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LocationOpenDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("locationClosedDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LocationClosedDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("isNextScheduledMovement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNextScheduledMovement { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastLocationUpdateDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastLocationUpdateDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipmentStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShipmentStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shipmentNotes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShipmentNotes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("arrivalDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ArrivalDateTimeUTC { get; set; }
    
        [Newtonsoft.Json.JsonProperty("departureDateTimeUTC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DepartureDateTimeUTC { get; set; }
    
    
    }
}