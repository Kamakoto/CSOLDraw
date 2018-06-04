using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOG : MonoBehaviour {
    public TweenPosition log;
    private bool isplay=false;
	// Use this for initialization

    void OnClick()
    {
        if (!isplay)
        {
            log.PlayForward();
            isplay = true;
        }
        else
        {
            log.PlayReverse();
            isplay = false;
        }
    }
}
