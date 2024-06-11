using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BasicRuntimeTests : BaseTests
{
    [OneTimeSetUp]
    public void EOneTimeSetUp()
    {
        Log("ROneTimeSetUp");
    }

    [OneTimeTearDown]
    public void EOneTimeTearDown()
    {
        Log("ROneTimeTearDown");
    }

    [UnityOneTimeSetUp]
    public IEnumerator EUnityOneTimeSetUp()
    {
        Log("RUnityOneTimeSetUp");
        yield return null;
        Log("RUnityOneTimeSetUp");
    }

    [UnityOneTimeTearDown]
    public IEnumerator EUnityOneTimeTearDown()
    {
        Log("RUnityOneTimeTearDown");
        yield return null;
        Log("RUnityOneTimeTearDown");
    }

    [SetUp]
    public void ESetUp()
    {
        Log("RSetUp");
    }

    [TearDown]
    public void ETearDown()
    {
        Log("RTearDown");
    }


    [UnitySetUp]
    public IEnumerator EUnitySetUp()
    {
        Log("RUnitySetUp");
        yield return null;
        Log("RUnitySetUp");
    }

    [UnityTearDown]
    public IEnumerator EUnityTearDown()
    {
        Log("RUnityTearDown");
        yield return null;
        Log("RUnityTearDown");
    }

    // A Test behaves as an ordinary method
    [Test]
    public void BasicTestsSimplePasses1()
    {
        Log("BasicTestsSimplePasses");
    }

    [Test]
    public void BasicTestsSimplePasses2()
    {
        Log("BasicTestsSimplePasses");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator BasicTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        Log("BasicTestsWithEnumeratorPasses");
        yield return null;
        Log("BasicTestsWithEnumeratorPasses");
    }
}
