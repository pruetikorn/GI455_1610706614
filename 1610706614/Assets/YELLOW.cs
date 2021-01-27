using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YELLOW : MonoBehaviour
{
    public string n;
    public GameObject ip;
    public GameObject op;
    public void ListName()
    {

        n = ip.GetComponent<Text>().text;
        if (n == "Unity" || n == "Unreal" || n == "BOB" || n =="Google"||n=="MongoDB")
        {
            op.GetComponent<Text>().text = "<color=green>"+n+"</color>"+ " is found";
        }
        
        else
        {
            op.GetComponent<Text>().text = "<color=red>" + n + "</color>" + " isnot found";
        }

    }
 }