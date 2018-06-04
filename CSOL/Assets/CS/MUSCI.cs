using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSCI : MonoBehaviour {
    
    public AudioSource music1, music2;
    public UILabel name;
    int id = 2;
    void OnClick(){

        if (id == 2) 
        {
            name.text="CSO1大厅";
            music2.Play();
            music1.Stop();
            id = 1;
        }
        else if(id ==1)
        {
            name.text = "CSO2圣诞";
            music1.Play();
            music2.Stop();
            id = 2;
        }

        

    }
}
