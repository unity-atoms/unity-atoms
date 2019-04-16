using System;

namespace UnityAtoms.Extensions
{
    public static class IObservableExtensions
    {
        public static IObservable<M> MergeObservables<T1, T2, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2,
            Func<T1, T2, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            return new MergeObservables<T1, T2, M>(observable1, observable2, createCombinedModel, initialValue1, initialValue2);
        }

        public static IObservable<M> MergeObservables<T1, T2, T3, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3,
            Func<T1, T2, T3, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            return new MergeObservables<T1, T2, T3, M>(observable1, observable2, observable3, createCombinedModel, initialValue1, initialValue2, initialValue3);
        }

        public static IObservable<M> MergeObservables<T1, T2, T3, T4, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4,
            Func<T1, T2, T3, T4, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            return new MergeObservables<T1, T2, T3, T4, M>(observable1, observable2, observable3, observable4, createCombinedModel, initialValue1, initialValue2, initialValue3, initialValue4);
        }

        public static IObservable<M> MergeObservables<T1, T2, T3, T4, T5, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4, IObservable<T5> observable5,
            Func<T1, T2, T3, T4, T5, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            return new MergeObservables<T1, T2, T3, T4, T5, M>(observable1, observable2, observable3, observable4, observable5, createCombinedModel, initialValue1, initialValue2, initialValue3, initialValue4, initialValue5);
        }
    }
}
