namespace SportProductsWeb.Services
{
    public class EmailSetting
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }
    }
}
