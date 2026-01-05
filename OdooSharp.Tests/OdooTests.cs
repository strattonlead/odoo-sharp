using OdooSharp.Client;
using OdooSharp.Configuration;
using OdooSharp.Models;
using OdooSharp.Queries;
using System.Text.Json;

namespace OdooSharp.Tests
{
    public class OdooTests
    {
        OdooClientOptions Options;
        public OdooTests()
        {
            var envVars = new EnvVars();
            Options = new OdooClientOptions()
            {
                Database = envVars.Database,
                Username = envVars.Username,
                Password = envVars.Password,
                Url = envVars.Url
            };
        }

        [Fact]
        public async void CreateGetUpdateCountDeleteTest()
        {
            var client = new OdooClient(Options);
            await client.AuthenticateAsync();

            var test = await client.ReadById<ResPartner>(1);

            var query = await client.Query<ResPartner>().Where(x => x.Name.Contains("Bieber")).ToListAsync();

            var companyPartner = new ResPartner()
            {
                Name = "Mustermann Logistik GmbH",
                CompanyName = "Mustermann Logistik GmbH",
                IsCompany = true,
                Email = "kontakt@mustermann-logistik.de",
                Phone = "+49 123 456789",
                AutopostBills = "never",
                Active = true
            };

            // Beispiel für ein custom feld aus dem studio. generieren lassen oder manuell einfügen
            //[JsonPropertyName("x_studio_timocompublicid")]
            //[OdooField("x_studio_timocompublicid")]
            //public int TimocomId { get; set; }

            var info = await client.GetModelFieldsTypedAsync("res.partner");
            var info2 = await client.GetModelFieldTypedAsync("res.partner", "x_studio_languages");

            var countResponse = await client.SearchReadCountAsync<ResPartner>();

            var createResponse = await client.CreateAsync(companyPartner);

            var person = new ResPartner()
            {
                Name = "Tanja Hörerabnehmer",
                IsCompany = false,
                Email = "kontakt@mustermann-logistik.de",
                Phone = "+49 123 456789",
                AutopostBills = "never",
                Active = true,
                ParentId = createResponse.Result,
            };

            createResponse = await client.CreateAsync(person);

            var readResult = await client.SearchReadAsync<ResPartner>();

            countResponse = await client.SearchReadCountAsync<ResPartner>();

            var deleteResult = await client.DeleteAsync<ResPartner>(createResponse.Result);

            countResponse = await client.SearchReadCountAsync<ResPartner>();
        }

        [Fact]
        public void DynamicWriteTest()
        {
            var client = new OdooClient(Options);
            var original = new SaleOrder()
            {
                Signature = new byte[] { 1, 2, 3, 4, 5, }

            };
            var modified = new SaleOrder()
            {
                DateOrder = DateTime.UtcNow,
                Signature = new byte[] { 1, 2, 3, 4, 5, 6 }
            };
            var changed = client.GetChangedFields(original, modified);

            var a = JsonSerializer.Serialize(original);
            var b = JsonSerializer.Serialize(modified);
            var c = JsonSerializer.Serialize(changed);
        }

        [Fact]
        public async void UserLoginTest()
        {
            var client = new OdooClient(Options);
            var result = await client.AuthenticateUserAsync(Options.Username, Options.Password);
        }

        [Fact]
        public async void GetIrAttachmentTest()
        {

            var client = new OdooClient(Options);
            var result = await client.AuthenticateAsync();

            //var read = await client.ReadById<IrAttachment>(24356);

            var domain = new object[]
            {
                new object[] { "id", "=", 24356 }
            };
            var readResult = await client.SearchReadAsync<IrAttachment>(
                domain: domain,
                fields: new[] { "id", "name", "mimetype", "datas" },
                limit: 1
            );

        }

        [Fact]
        public async void UserLoginLightTest()
        {
            IOdooClient client = new OdooClient(Options);
            var result = await client.AuthenticateUserLightAsync(Options.Username, Options.Password);
        }

    }
}