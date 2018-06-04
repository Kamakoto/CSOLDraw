using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour {

    public UILabel AmmoNumber;
    private int Number = 0;
	// Use this for initialization
	void Start () {
        for (int a = 1; a < 17; a++)
        {
            GameObject.Find(a.ToString()).GetComponent<UIButton>().enabled = false;
            GameObject.Find(a.ToString()).GetComponent<UISprite>().spriteName = a.ToString() + "-2";
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReFresh(){
        AmmoNumber.text=Number+"颗";
    }


    public void AddAmmo()
    {
        Number += 10;
        ReFresh();
    }

    public void UseAmmo()
    {
        Number -= 1;
        ReFresh();
        if (Number < 0)
        {
            for (int a = 1; a < 17; a++)
            {
                GameObject.Find(a.ToString()).GetComponent<UIButton>().enabled = false;
                GameObject.Find(a.ToString()).GetComponent<UISprite>().spriteName = a.ToString() + "-2";
                GameObject.Find("2223").GetComponent<UILabel>().text = "某曹：没钱还想玩游戏？请！";
            }
        }
    }

    
}
