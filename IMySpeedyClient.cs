namespace ca.speedy.my
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.1.2.0 (NJsonSchema v10.0.24.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IMySpeedyClient
    {
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DashboardModel_V1> GetDashboardDataAsync(System.DateTimeOffset? date);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<DashboardModel_V1> GetDashboardDataAsync(System.DateTimeOffset? date, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task GetIdentityDataAsync();
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task GetIdentityDataAsync(System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetPowerUnitIconAsync(bool? point, string powerUnit, bool? dropShadow);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetPowerUnitIconAsync(bool? point, string powerUnit, bool? dropShadow, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetMovementIconAsync(string text, bool? point, bool? dropShadow, MovementTypeEnum_V1? movementTypeEnum, int? innerRed, int? innerGreen, int? innerBlue, int? outerRed, int? outerGreen, int? outerBlue, int? fontRed, int? fontGreen, int? fontBlue);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetMovementIconAsync(string text, bool? point, bool? dropShadow, MovementTypeEnum_V1? movementTypeEnum, int? innerRed, int? innerGreen, int? innerBlue, int? outerRed, int? outerGreen, int? outerBlue, int? fontRed, int? fontGreen, int? fontBlue, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetMapIconAsync(string text, bool? point, bool? dropShadow, int? alpha, int? innerRed, int? innerGreen, int? innerBlue, int? outerRed, int? outerGreen, int? outerBlue, int? fontRed, int? fontGreen, int? fontBlue, int? outlineAlpha, int? outlineRed, int? outlineGreen, int? outlineBlue, int? backgroundAlpha, int? backgroundRed, int? backgroundGreen, int? backgroundBlue);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetMapIconAsync(string text, bool? point, bool? dropShadow, int? alpha, int? innerRed, int? innerGreen, int? innerBlue, int? outerRed, int? outerGreen, int? outerBlue, int? fontRed, int? fontGreen, int? fontBlue, int? outlineAlpha, int? outlineRed, int? outlineGreen, int? outlineBlue, int? backgroundAlpha, int? backgroundRed, int? backgroundGreen, int? backgroundBlue, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetLocationHistoryIconAsync(int? red, int? green, int? blue, int? alpha);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetLocationHistoryIconAsync(int? red, int? green, int? blue, int? alpha, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetTerminalIconAsync(string scac, bool? point, bool? dropShadow);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetTerminalIconAsync(string scac, bool? point, bool? dropShadow, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetInvoicePDFAsync(string invoiceNumber);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetInvoicePDFAsync(string invoiceNumber, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<InvoiceDataModel_V1> GetInvoiceDataAsync(string invoiceNumber);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<InvoiceDataModel_V1> GetInvoiceDataAsync(string invoiceNumber, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetProofOfDeliveryPDFAsync(string proNumber);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<byte[]> GetProofOfDeliveryPDFAsync(string proNumber, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<RateQuoteModel_V1> PostRateQuoteAsync(RateQuoteRequestModel_V1 quoteRequestModel);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<RateQuoteModel_V1> PostRateQuoteAsync(RateQuoteRequestModel_V1 quoteRequestModel, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<TerminalModel_V1>> GetTerminalData(string scac);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<TerminalModel_V1>> GetTerminalData(string scac, System.Threading.CancellationToken cancellationToken);
    
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ShipmentModel_V1> GetTrackShipmentAsync(string trackingNumber);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ShipmentModel_V1> GetTrackShipmentAsync(string trackingNumber, System.Threading.CancellationToken cancellationToken);
    
    }
}