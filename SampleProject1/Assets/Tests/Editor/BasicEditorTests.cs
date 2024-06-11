using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BasicEditortests : BaseTests
{
    [OneTimeSetUp]
    public void EOneTimeSetUp()
    {
        Log("EOneTimeSetUp");
    }

    [OneTimeTearDown]
    public void EOneTimeTearDown()
    {
        Log("EOneTimeTearDown");
    }

    [UnityOneTimeSetUp]
    public IEnumerator EUnityOneTimeSetUp()
    {
        Log("EUnityOneTimeSetUp");
        yield return null;
        Log("EUnityOneTimeSetUp");
    }

    [UnityOneTimeTearDown]
    public IEnumerator EUnityOneTimeTearDown()
    {
        Log("EUnityOneTimeTearDown");
        yield return null;
        Log("EUnityOneTimeTearDown");
    }

    [SetUp]
    public void ESetUp()
    {
        Log("ESetUp");
    }

    [TearDown]
    public void ETearDown()
    {
        Log("ETearDown");
    }


    [UnitySetUp]
    public IEnumerator EUnitySetUp()
    {
        Log("EUnitySetUp");
        yield return null;
        Log("EUnitySetUp");
    }

    [UnityTearDown]
    public IEnumerator EUnityTearDown()
    {
        Log("EUnityTearDown");
        yield return null;
        Log("EUnityTearDown");
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
