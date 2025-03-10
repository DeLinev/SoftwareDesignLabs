using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public abstract class SubscriptionCreator
    {
        public abstract ISubscription CreateDomesticSubsription();
        public abstract ISubscription CreateEducationalSubsription();
        public abstract ISubscription CreatePremiumSubscription();
    }
}
