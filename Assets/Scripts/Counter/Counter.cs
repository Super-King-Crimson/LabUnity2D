using System;

namespace Lab.Counter
{
    interface ICounter
    {
        void Increment();
    }

    public class CounterStartBeyondBoundsException : Exception
    {
        public override string Message { get; } = "Failed to create a counter: ";

        public CounterStartBeyondBoundsException(string message)
        {
            Message += message;
        }
    }

    public class Counter : ICounter
    {
        public const int MaxCount = 10;

        public int Count { get; private set; }

        public Counter()
        {
            Count = 0;
        }

        public Counter(int startAt)
        {
            if (startAt > MaxCount)
            {
                throw new CounterStartBeyondBoundsException($"maximum counter value is {Counter.MaxCount} but given start value was {startAt}");
            }

            Count = startAt;
        }

        public void Increment()
        {
            Count = Math.Min(Count + 1, MaxCount);
        }
    }
}