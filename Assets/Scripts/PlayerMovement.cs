using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    readonly float SPEED = 1;

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

    float LerpC(float a, float b, float c, float d, float t)
    {
        return Lerp(
            LerpQ(a, b, c, t),
            LerpQ(b, c, d, t),
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
        (float inputX, float inputY) = (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        gameObject.transform.position += new Vector3(
            inputX * SPEED * Time.deltaTime, 
            inputY * SPEED * Time.deltaTime, 
            0
        );
    }
}
