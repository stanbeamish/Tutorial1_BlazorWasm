using Fluxor;

namespace MyApp.Client.Store.Counter
{
    public class CounterFeature : Feature<CounterState>
    {
        public override string GetName()
        {
            return nameof(CounterState);
        }

        protected override CounterState GetInitialState()
        {
            return new CounterState
            {
                Count = 0
            };
        }
    }
}
