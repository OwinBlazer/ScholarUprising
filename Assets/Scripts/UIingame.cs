using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIingame : MonoBehaviour {
    public static UIingame instance;
    private Color tmp;

    void Start()
    {
        instance = this;
    }

}
