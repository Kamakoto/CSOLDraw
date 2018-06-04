using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo_add : MonoBehaviour {

    void OnClick()
    {
        GameObject.Find("AMMO").SendMessage("AddAmmo");
    }
}
