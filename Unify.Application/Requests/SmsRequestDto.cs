namespace Unify.Application.Requests
{
    public class SmsRequestDto
    {
        public string Recipient { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Sender { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}
