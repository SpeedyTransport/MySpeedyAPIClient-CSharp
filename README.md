# MySpeedyAPIClient-CSharp
<h3>Example client to connect to the MySpeedy.ca RESTful API</h3><br />
<br />
First, register @ <a href="https://www.myspeedy.ca">https://www.myspeedy.ca</a> and follow the instructions thru validating your email address, and attaching your MySpeedy.ca login to your Speedy Transportation account.<br />
<br />
Once you have completed setting up your account and have signed in, your refresh token will be available at <a href="https://www.myspeedy.ca/settings/api">https://www.myspeedy.ca/settings/api</a>.  Copy the refresh token into Program.cs (approx line 23) replacing the placeholder text. i.e.<br />
<br />
<b>private static string RefreshToken = "*your refresh token goes here*"</b><br />
will become...<br />
<b>private static string RefreshToken = "1b9f7a1f2ec6432f93d11bf2bcb5cf93d2608e5adecef4999d4c606560c4b603"</b><br />
<br />
<br />
Next, copy a sample PRO number of your choice, preferably a Speedy PRO for a shipment that has been invoiced, into Program.cs (approx line 26) replacing the placeholder text.<br />
<br />
<b>private static string ExamplePRONumber = "Your Speedy PRO goes here"</b><br />
will become...<br />
<b>private static string ExamplePRONumber = "61234567890"</b><br />
<br />
<br />
Step through the code to see a response for tracking a shipment, pulling an invoice, etc.<br />
<br />
<br />
This example project uses <a href="https://github.com/RicoSuter/NSwag">NSwag</a> generated models and client code to pull from the MySpeedy.ca API located at <a href="https://api.myspeedy.ca/swagger/">https://api.myspeedy.ca/swagger/</a>.  It also uses <a href="https://github.com/IdentityServer/IdentityServer4/">IdentityServer4 client</a> to create an authenticated request to the API.
