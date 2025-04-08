using Bertini.Notificationcontext;

namespace Bertini.SharedContext {

    
    public abstract class Base : Notifiable
    {
        public Base()
    {
        Id = Guid.NewGuid();
    }
        public Guid Id { get; set; }
    }
}