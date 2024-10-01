namespace Unify.Application.Requests
{
    public class EmailRequestDto
    {
        public string Subject { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the recepient
        /// </summary>
        public string Recepient { get; set; } = string.Empty;
        public string? CC { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Sender { get; set; } = string.Empty;
        /// <summary>
        /// Sets the list of attachment url
        /// </summary>
        public List<string>? Attachments { get; set; }

    }
}
