using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace ca.speedy.my
{
    public class Program
    {
        

        // Do not change anything in this block
        private const string MySpeedyAPIURL = "https://api.myspeedy.ca";
        private const string MySpeedyAuthenticationURL = "https://login.myspeedy.ca";
        private const string APIMySpeedyClientId = "myspeedy.api";
        private const string APISecret = "secretpassword";
        private const string APIScope = "apiv1";
        // End do not change anything in this block

        // Change this to your refresh token from https://www.myspeedy.ca/settings/api
        private static string RefreshToken = "your refresh token goes here"; // e.g. "1b9f7a1f2ec6432f93d11bf2bcb5cf93d2608e5adecef4999d4c606560c4b603";

        // Change this to a live Speedy PRO you would like pull information for
        private static string ExamplePRONumber = "Your Speedy PRO goes here"; // e.g. "61234567890"

        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                var httpClient = new HttpClient();
                var bearerToken = await GetBearerToken();

                bearerToken = await GetBearerToken();

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                var mySpeedyClient = new MySpeedyMySpeedyClient(MySpeedyAPIURL, httpClient);

                var trackShipmentData = await mySpeedyClient.GetTrackShipmentAsync(ExamplePRONumber);
                var invoicePDFBytes = await mySpeedyClient.GetInvoicePDFAsync(ExamplePRONumber);
                using (var fs = new FileStream(@".\myspeedy_client_test_invoice.pdf", FileMode.OpenOrCreate))
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    fs.Write(invoicePDFBytes, 0, invoicePDFBytes.Length);
                    fs.Flush();
                }
                var proofOfDeliveryPDFBytes = await mySpeedyClient.GetProofOfDeliveryPDFAsync(ExamplePRONumber);
                using (var fs = new FileStream(@".\myspeedy_client_test_pod.pdf", FileMode.OpenOrCreate))
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    fs.Write(proofOfDeliveryPDFBytes, 0, proofOfDeliveryPDFBytes.Length);
                    fs.Flush();
                }

                var invoiceData = await mySpeedyClient.GetInvoiceDataAsync(ExamplePRONumber);
            });

            Thread.Sleep(-1);
        }

        private static async Task<string> GetBearerToken()
        {
            var httpClient = new HttpClient();
            var discoveryResponse = await DiscoveryClient.GetAsync(MySpeedyAuthenticationURL);

            if (discoveryResponse.IsError)
            {
                throw new InvalidOperationException(discoveryResponse.Error);
            }

            var tokenResponse = await httpClient.RequestRefreshTokenAsync(new RefreshTokenRequest {Address = discoveryResponse.TokenEndpoint, ClientId = APIMySpeedyClientId, ClientSecret = APISecret, Scope = APIScope, RefreshToken = RefreshToken});

            if (tokenResponse.IsError)
            {
                throw new InvalidOperationException(tokenResponse.Error);
            }

            RefreshToken = tokenResponse.RefreshToken;

            return tokenResponse.AccessToken;
        }
    }
}
