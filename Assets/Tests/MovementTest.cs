using NUnit.Framework;

public class MovementTest
{
    public static int[] dummy = new int[] { 0 };

    [Test]
    public void BuildTest([ValueSource("dummy")] int _)
    {
        // Passes as long as the game builds.
        Assert.That(true);
    }

    [Test]
    public void ConstantTest([ValueSource("dummy")] int _)
    {
        Assert.That(Particle2D.PassTest, "Constant 'Particle2D.PassTest' is false.");
    }
}
