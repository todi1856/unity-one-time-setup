using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BasicEditortests
{
    static int s_Counter = 0;

    [OneTimeSetUp]
    public void EOneTimeSetUp()
    {
        Utilities.Log("EOneTimeSetUp" + (s_Counter++));
    }

    [OneTimeTearDown]
    public void EOneTimeTearDown()
    {
        Utilities.Log("ETearDown" + (s_Counter++));
    }

    [UnityOneTimeSetUp]
    public IEnumerator EUnityOneTimeSetUp()
    {
        Utilities.Log("EUnityOneTimeSetUp" + (s_Counter++));
        yield return null;
        Utilities.Log("EUnityOneTimeSetUp" + (s_Counter++));
    }

    [UnityOneTimeTearDown]
    public IEnumerator EUnityOneTimeTearDown()
    {
        Utilities.Log("UnityOneTimeTearDown" + (s_Counter++));
        yield return null;
        Utilities.Log("UnityOneTimeTearDown" + (s_Counter++));
    }

    [SetUp]
    public void ESetUp()
    {
        Utilities.Log("ETearDown" + (s_Counter++));
    }

    [TearDown]
    public void ETearDown()
    {
        Utilities.Log("ETearDown" + (s_Counter++));
    }


    [UnitySetUp]
    public IEnumerator EUnitySetUp()
    {
        Utilities.Log("EUnitySetUp" + (s_Counter++));
        yield return null;
        Utilities.Log("EUnitySetUp" + (s_Counter++));
    }

    [UnityTearDown]
    public IEnumerator EUnityTearDown()
    {
        Utilities.Log("EUnityTearDown" + (s_Counter++));
        yield return null;
        Utilities.Log("EUnityTearDown" + (s_Counter++));
    }

    // A Test behaves as an ordinary method
    [Test]
    public void BasicTestsSimplePasses1()
    {
        Utilities.Log("BasicTestsSimplePasses" + (s_Counter++));
    }

    [Test]
    public void BasicTestsSimplePasses2()
    {
        Utilities.Log("BasicTestsSimplePasses" + (s_Counter++));
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator BasicTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        Utilities.Log("BasicTestsWithEnumeratorPasses" + (s_Counter++));
        yield return null;
        Utilities.Log("BasicTestsWithEnumeratorPasses" + (s_Counter++));
    }
}
