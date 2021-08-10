using Fluxor;
using MyApp.Client.Store.Counter.Actions;

namespace MyApp.Client.Store.Counter
{
    public static class CounterReducers
    {
        [ReducerMethod]
        public static CounterState OnIncrementCounterAction(CounterState state, IncrementCounterAction action)
        {
            return state with
            {
                Count = state.Count + 1
            };
        }

        [ReducerMethod]
        public static CounterState OnDecrementCounterAction(CounterState state, DecrementCounterAction action)
        {
            return state with
            {
                Count = state.Count - 1
            };
        }
    }
}
