using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
    bool isPlaying = false;
    public int score = 0;
    int Z1 = 0;
    int Z2 = 0;
    bool Z22 = true;
    int Z3 = 0;
    bool Z33 = true;
    int Z4= 0;
    bool Z44 = true;
    public UILabel Log;
	// Use this for initialization
	void OnClick () {
        for (int a = 1; a < 17; a++)
        {
            GameObject.Find(a.ToString()).GetComponent<UIButton>().enabled = true;
            GameObject.Find(a.ToString()).GetComponent<UISprite>().spriteName = a.ToString() + "-1";
        }
        score = 0;
        GameObject.Find("ZOMBIE").GetComponent<UILabel>().text = "12";
        GameObject.Find("BOX").GetComponent<UILabel>().text = "四级青铜箱";
        GameObject.Find("BOXPIC").GetComponent<UISprite>().spriteName = "A";
        string logg="";
        GameObject.Find("2223").GetComponent<UILabel>().text = "";
        Z1 = Random.Range(1, 16);

        Z2 = Random.Range(1, 16);
        while (Z22)
        {
            if (Z2 == Z1)
            {
                Z2 = Random.Range(1, 16);
                logg = ("随机数2在生成时发生了重复，现已重新生成\n");
            }
            else
            {
                Z22 = false;
            }
        }

        Z3 = Random.Range(1, 16);
        while(Z33)
        {
            if (Z3 == Z2||Z3==Z1)
            {
                Z3 = Random.Range(1, 16);
                logg += ("随机数3在生成时发生了重复，现已重新生成\n");
            }
            else
            {
                Z33= false;
            }
        }

        Z4 = Random.Range(1, 16);
        while (Z44)
        {
            if (Z4 == Z3 || Z4 == Z2 || Z4 == Z1)
            {
                Z4 = Random.Range(1, 16);
                logg += ("随机数4在生成时发生了重复，现已重新生成\n");
            }
            else
            {
                Z44 = false;
            }
        }

        Z22 = true;
        Z33 = true;
        Z44 = true;
        logg += "No.1=" + Z1 + "    No.2=" + Z2 + "\nNo.3=" + Z3 + "    No.4=" + Z4;
       Log.text = logg;
	}


    public void Draw(int id)
    {
        GameObject.Find("AMMO").SendMessage("UseAmmo");
        if (id == Z1 || id == Z2 || id == Z3 || id == Z4)
        {

            for (int a = 1; a < 17; a++)
            {
                GameObject.Find(a.ToString()).GetComponent<UIButton>().enabled = false;
                GameObject.Find(a.ToString()).GetComponent<UISprite>().spriteName = a.ToString() + "-2";
            }
            GameObject.Find(Z1.ToString()).GetComponent<UISprite>().spriteName = Z1.ToString() + "-3";
            GameObject.Find(Z2.ToString()).GetComponent<UISprite>().spriteName = Z2.ToString() + "-3";
            GameObject.Find(Z3.ToString()).GetComponent<UISprite>().spriteName = Z3.ToString() + "-3";
            GameObject.Find(Z4.ToString()).GetComponent<UISprite>().spriteName = Z4.ToString() + "-3";

        }
        else
        {

            GameObject.Find(id.ToString()).GetComponent<UIButton>().enabled = false;
            GameObject.Find(id.ToString()).GetComponent<UISprite>().spriteName = id.ToString() + "-2";
            int ID =int.Parse(GameObject.Find("ZOMBIE").GetComponent<UILabel>().text);
            ID -= 1;
            GameObject.Find("ZOMBIE").GetComponent<UILabel>().text = ID.ToString();


            score += 1;
            switch(score)
            {
                case 1:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "三级青铜箱";
                break;
                case 2:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "二级青铜箱";
                break;
                case 3:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "一级青铜箱";
                break;
                case 4:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "四级白银箱";
                GameObject.Find("BOXPIC").GetComponent<UISprite>().spriteName ="B";
                break;
                case 5:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "三级白银箱";
                break;
                case 6:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "二级白银箱";
                break;
                case 7:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "一级白银箱";
                break;
                case 8:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "四级黄金箱";
                GameObject.Find("BOXPIC").GetComponent<UISprite>().spriteName = "C";
                break;
                case 9:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "三级黄金箱";
                break;
                case 10:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "二级黄金箱";
                break;
                case 11:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "一级黄金箱";
                break;
                case 12:
                GameObject.Find("BOX").GetComponent<UILabel>().text = "至尊曹年宝";
                break;
        }
        }
    }
}
