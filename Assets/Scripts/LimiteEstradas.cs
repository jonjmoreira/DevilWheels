using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteEstradas : MonoBehaviour
{
    public MotorEstradas motorEstradasScript;

    public void OnTriggerEnter2D( Collider2D cInfo )
    {
        if ( cInfo.gameObject.tag == "LimiteEstradas" )
        {
            Destroy(cInfo.transform.parent.gameObject);
            motorEstradasScript.CriarEstradas();
        }
    }
}
