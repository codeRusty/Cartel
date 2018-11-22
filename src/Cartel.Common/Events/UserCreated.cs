namespace Cartel.Common.Events
{
    public class UserCreated:IEvent
    {
        public string Email { get;  }
        public string Name { get; }

// So that serializer do not have any issue
        protected UserCreated()
        {
            
        }  
        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}