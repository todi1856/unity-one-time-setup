using NUnit.Framework;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

/*
namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Method)]
    public class UnityOneTimeSetUpAttribute : NUnitAttribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class UnityOneTimeTearDownAttribute : NUnitAttribute
    {
    }
}
//*/

public class BaseTests
{
    private static int s_BaseCounter;

    protected static void Log(string message)
    {
        Utilities.Log(message + (s_BaseCounter++) + $" F:" + Time.frameCount);
    }

    [OneTimeSetUp]
    public void BaseOneTimeSetUp()
    {
        Log("BaseOneTimeSetUp");
    }

    [OneTimeTearDown]
    public void BaseOneTimeTearDown()
    {
        Log("BaseOneTimeTearDown");
    }

    [UnityOneTimeSetUp]
    public IEnumerator BaseUnityOneTimeSetUp()
    {
        Log("BaseUnityOneTimeSetUp");
        yield return null;
        Log("BaseUnityOneTimeSetUp");
    }

    [UnityOneTimeTearDown]
    public IEnumerator BaseUnityOneTimeTearDown()
    {
        Log("BaseUnityOneTimeTearDown");
        yield return null;
        Log("BaseUnityOneTimeTearDown");
    }

    [SetUp]
    public void BaseSetUp()
    {
        Log("BaseSetUp");
    }

    [TearDown]
    public void BaseTearDown()
    {
        Log("BaseTearDown");
    }


    [UnitySetUp]
    public IEnumerator BaseUnitySetUp()
    {
        Log("BaseUnitySetUp");
        yield return null;
        Log("BaseUnitySetUp");
    }

    [UnityTearDown]
    public IEnumerator BaseUnityTearDown()
    {
        Log("BaseUnityTearDown");
        yield return null;
        Log("BaseUnityTearDown");
    }
}
