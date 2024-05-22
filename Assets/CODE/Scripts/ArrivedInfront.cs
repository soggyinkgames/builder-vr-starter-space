using System.Collections;
using UnityEngine;

public class ArrivedInfront : MonoBehaviour
{

    public Material WaterDissolve;


    void OnTriggerEnter (Collider Player)
    {
        WaterDissolve.SetFloat("_Dissolve", 0);
    }
    void OnTriggerStay (Collider Player)
    {
        Debug.Log ("Object is within trigger");
    }
    void OnTriggerExit (Collider Player)
    {
        WaterDissolve.SetFloat("_Dissolve", 1);
    }
}

