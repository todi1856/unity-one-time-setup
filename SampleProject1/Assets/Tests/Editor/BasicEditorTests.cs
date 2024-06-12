using System;
using System.Collections;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

public class OneTimeSetUpTearDownExample
{
    DateTime start;

    [OneTimeSetUp]
    public void Start()
    {
        //start = DateTime.Now;
    }

    [OneTimeTearDown]
    public void Finish()
    {
        //Utilities.Log($"Finished {(DateTime.Now - start).TotalMilliseconds} ms.");
    }

    [UnityOneTimeSetUp]
    public IEnumerator UnityOneTimeSetUp()
    {
        yield return new EnterPlayMode();
    }

    [UnityOneTimeTearDown]
    public IEnumerator UnityOneTimeTearDown()
    {
        yield return new ExitPlayMode();
    }

    [Test]
    public void MyTest1()
    {
        Debug.Log("This runs inside playmode");
    }

    [Test]
    public void MyTest2()
    {
        Debug.Log("This runs inside playmode too");
    }

    [Test]
    public void MyTest3()
    {
        Debug.Log("This runs inside playmode too");
    }

    [Test]
    public void MyTest4()
    {
        Debug.Log("This runs inside playmode too");
    }

    [Test]
    public void MyTest5()
    {
        Debug.Log("This runs inside playmode too");
    }
}

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
