using Bertini.SharedContext;
namespace Bertini.SubscriptionContext
{
    // Subscription is a class that inherits from Base class.
    // It represents a subscription in the subscription context of the application.
    // It does not have any additional properties or methods defined in it yet.
public class Subscription : Base
{
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }

    public bool IsInactive => EndDate <= DateTime.Now;
}
}
