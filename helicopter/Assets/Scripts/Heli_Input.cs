using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heli_Input : MonoBehaviour
{
    public float X { get; private set; }
    public float Y { get; private set; }
    public bool EngineOnOff { get; private set; }


    void Update()
    {
        X = 0f;
        Y = 0f;

        EngineOnOff = false;

        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

        EngineOnOff = Input.GetKeyDown(KeyCode.Z);

    }
}
