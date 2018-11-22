using System;

namespace Cartel.Common.Events
{
    public class ActivityCreated : IEvent
    {
        public Guid Id { get; }
        public Guid UserID { get; }
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }

        protected ActivityCreated()
        {
        }
        public ActivityCreated(Guid id, Guid userID, string category, string name, string description)
        {
            Id = id;
            UserID = userID;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
        }
    }


}