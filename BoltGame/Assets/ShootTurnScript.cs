using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTurnScript : MonoBehaviour
{
    public Transform player;


    void Update()
    {

        if (player.eulerAngles.y == (0))
        {
            this.transform.eulerAngles = new Vector3(0, 0, 0);
            Debug.Log("Facing right");
            Debug.Log(this.transform.eulerAngles);
        }
        else //if (player.eulerAngles.y > -180)
        {
            this.transform.eulerAngles = new Vector3(0,0,90);
            Debug.Log(player.transform.eulerAngles.y);
            Debug.Log("Facing left");
        }
        
    }

}//end of stript

