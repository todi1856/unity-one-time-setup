using NUnit.Framework;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

public class RecompileTests
{
    [OneTimeSetUp]
    public void RecompileTestsOneTimeSetUp()
    {
        Utilities.Log("RecompileTestsOneTimeSetUp");
    }

    [UnityOneTimeSetUp]
    public IEnumerator RecompileTestsOneTimeSetUpEnumerator()
    {
        Utilities.Log("RecompileTestsOneTimeSetUpEnumerator");
        yield return null;
    }

    [SetUp]
    public void RecompileTestsSetUp()
    {
        Utilities.Log("RecompileTestsSetUp");
    }

    [UnitySetUp]
    public IEnumerator RecompileTestsSetUpEnumerator()
    {
        Utilities.Log("RecompileTestsSetUpEnumerator");
        yield return null;
    }

    [OneTimeTearDown]
    public void RecompileTestsOneTimeTearDown()
    {
        Utilities.Log("RecompileTestsOneTimeTearDown");
        System.IO.File.Delete("Assets/TestScript.cs");
    }

    [TearDown]
    public void RecompileTestsTearDown()
    {
        Utilities.Log("RecompileTestsTearDown");
    }

    [UnityTest]
    public IEnumerator TestWithDomainReload()
    {
        Utilities.Log("StartCreateScript");
        System.IO.File.WriteAllText("Assets/TestScript.cs", "class Dummy {}");
        AssetDatabase.Refresh();
        yield return new RecompileScripts();

        Utilities.Log("FinishedCreateScript");
    }
}