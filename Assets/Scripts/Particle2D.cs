using UnityEngine;

public class Particle2D : MonoBehaviour
{
    public const bool PassTest = false;

    public bool PassTestInstance = true;

    public void Start()
    {
        Debug.Log($"passTest: {PassTestInstance}");
    }
}
