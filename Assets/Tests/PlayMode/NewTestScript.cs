using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    [Test]
    public void CounterDefaultConstructorShouldStartAtZero()
    {
        var counter = new Counter();
        var counterExplicit = new Counter(0);

        Assert.Equals(counterExplicit.Count, counter.Count);
    }

    [Test]
    public void CounterShouldIncrementByOne()
    {
        var counter = new Counter();

        counter.Increment();

        Assert.Equals(counter.Count, 1);
    }

    [Test]
    public void CounterShouldNotIncrementAboveMaxCount()
    {
        var counter = new Counter(Counter.MaxCount);

        counter.Increment();

        Assert.Equals(counter.Count, Counter.MaxCount);
    }

    [Test]
    public void CounterShallNotBeGreaterThanMaxCount()
    {
        Assert.Throws<CounterStartBeyondBoundsException>(() => new Counter(Counter.MaxCount + 1));
    }
}
