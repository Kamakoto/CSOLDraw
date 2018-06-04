using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw : MonoBehaviour {

    void OnClick()
    {
        if (this.gameObject.GetComponent<UIButton>().enabled==true)
        {
            int id = int.Parse(this.gameObject.name);
            GameObject.Find("RESET").SendMessage("Draw", id);
            Debug.Log("!");
        }
        else
        {
        }
        
    }
}
