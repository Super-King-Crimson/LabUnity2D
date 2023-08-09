using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Lab.Tests
{
    using Counter;

    public class CounterTest
    {
        [Test]
        public void CounterDefaultConstructorShouldStartAtZero()
        {
            var counter = new Counter();
            var counterExplicit = new Counter(0);

            Assert.AreEqual(counterExplicit.Count, counter.Count);
        }

        [Test]
        public void CounterShouldIncrementByOne()
        {
            var counter = new Counter();

            counter.Increment();

            Assert.AreEqual(counter.Count, 1);
        }

        [Test]
        public void CounterShouldNotIncrementAboveMaxCount()
        {
            var counter = new Counter(Counter.MaxCount);

            counter.Increment();

            Assert.AreEqual(counter.Count, Counter.MaxCount);
        }

        [Test]
        public void CounterShallNotBeGreaterThanMaxCount()
        {
            Assert.Throws<CounterStartBeyondBoundsException>(() => new Counter(Counter.MaxCount + 1));
        }
    }
}