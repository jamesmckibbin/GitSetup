using UnityEngine;
using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class SceneTest
{
    private const string TestSceneId = "Assets/Scenes/TestScene.unity";

    public static int[] dummy = new int[] { 0 };

    [SetUp]
    public void LoadScene()
    {
        SceneManager.LoadScene(TestSceneId);
    }

    [UnityTest]
    public IEnumerator TestInstanceVariable([ValueSource("dummy")] int _)
    {
        yield return null;
        Particle2D particle = Object.FindObjectOfType<Particle2D>();
        Assert.That(particle, Is.Not.Null, "No Particle2D object found in scene.");
        Assert.That(particle.PassTestInstance, "Instance variable of 'PassTestInstance' is false.");
    }
}
