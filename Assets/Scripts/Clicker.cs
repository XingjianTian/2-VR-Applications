using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker{
    public bool clicked()
    {
        #if (UNITY_ANDROID || UNITY_IPHONE)
            return Cardboard.SDK.Triggered;
        #else
            return Input.anyKeyDown;
        #endif
    }
}
