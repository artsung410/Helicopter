using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heli_Input : MonoBehaviour
{
    public float X { get; private set; }
    public float Y { get; private set; }

    public bool FRONT { get; private set; }
    public bool BACK { get; private set; }
    public bool LEFT { get; private set; }
    public bool RIGHT { get; private set; }

    public bool EngineOnOff { get; private set; }


    void Update()
    {
        X = 0f;
        Y = 0f;

        EngineOnOff = false;
        FRONT = false;
        BACK = false;
        LEFT = false;
        RIGHT = false;

        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

        FRONT = Input.GetKey(KeyCode.I);
        BACK = Input.GetKey(KeyCode.K);
        LEFT = Input.GetKey(KeyCode.J);
        RIGHT = Input.GetKey(KeyCode.L);

        EngineOnOff = Input.GetKeyDown(KeyCode.Z);

    }
}
