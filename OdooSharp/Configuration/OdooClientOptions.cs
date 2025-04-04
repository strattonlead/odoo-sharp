namespace OdooSharp.Configuration
{
    public class OdooClientOptions
    {
        /// <summary>
        /// The URL to your Odoo instance in the format: https://yourinstance.odoo.com without trailing slash
        /// </summary>
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Your Database name.
        /// </summary>
        public string Database { get; set; } = string.Empty;

        /// <summary>
        /// Your username you usually login to use Odoo (e-mail)
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Your accounts password
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
