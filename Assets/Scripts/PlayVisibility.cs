using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVisibility : MonoBehaviour
{
    [SerializeField] private Animator dissolves;

    [SerializeField] private string appearing = "Appearing";

    // [SerializeField] private string visible = "Visible";

    private void OnTriggerEnter (Collider Player)
    {
        if(Player)
        {
            dissolves.Play("Appearing");
        }

    }

    private void OnTriggerStay (Collider Player) 
    {
        if(Player)
        {
            dissolves.SetBool("appearing", true);
        }
    }

        private void OnTriggerExit (Collider Player) 
    {
        if(Player)
        {
            dissolves.SetBool("appearing", false);
        }
    }
}
