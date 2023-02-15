using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePizza : MonoBehaviour
{
    public float flightLimit, timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += 1;
        if (timer > flightLimit)
        {
            Destroy(gameObject);
        }
    }
}
