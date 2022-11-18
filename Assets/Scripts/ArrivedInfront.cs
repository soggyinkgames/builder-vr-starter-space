using System.Collections;
using UnityEngine;

public class ArrivedInfront : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        Debug. Log ("Object Entered the trigger");
    }
    void OnTriggerStay (Collider other)
    {
        Debug. Log ("Object is within trigger");
    }
    void OnTriggerExit (Collider other)
    {
        Debug. Log ("Object Exited the trigger");
    }
}

