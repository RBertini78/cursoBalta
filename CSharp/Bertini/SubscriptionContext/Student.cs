using Bertini.Notificationcontext;
using Bertini.SharedContext;

namespace Bertini.SubscriptionContext
{
    public class Student : Base
    {

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Subscription", "You already have a subscription."));
                return;
            }
            // Add the subscription to the list of subscriptions
            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}