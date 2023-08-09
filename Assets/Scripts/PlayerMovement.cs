using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float Lerp(float a, float b, float t)
    {
        return a + t * (b - a);
    }

    float LerpQ(float a, float b, float c, float t)
    {
        return Lerp(
            Lerp(a, b, t),
            Lerp(b, c, t),
            t
        );
    }

    float LerpN(float a, float b, float t, float n)
    {
        float newA = b - ((b - a) * Mathf.Pow(1 - t, n - 1));

        return Lerp(newA, b, t);
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}
