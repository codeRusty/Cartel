namespace Cartel.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public string Email { get; set; }
        public string Reason {get;}

        public string Code {get;}

        protected CreateUserRejected(){}

        public CreateUserRejected(string reason, string code, string email)
        {
            Reason = reason;
            Code = code;
            Email=email;
        }
    }
}