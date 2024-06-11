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

    [SetUp]
    public void RecompileTestsSetUp()
    {
        Utilities.Log("RecompileTestsSetUp");
    }

    [UnitySetUp]
    public IEnumerator RecompileTestsSetUpEnumerator()
    {
        yield return CreateScript();
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

    private IEnumerable CreateScript()
    {
        Utilities.Log("Start");
        System.IO.File.WriteAllText("Assets/TestScript.cs", "class Dummy {}");
        AssetDatabase.Refresh();
        yield return new RecompileScripts();

        Utilities.Log("Finished");
    }
    [UnityTest]
    public IEnumerator TestWithDomainReload()
    {
        yield return CreateScript();
    }
}