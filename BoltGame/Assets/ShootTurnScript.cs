using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTurnScript : MonoBehaviour
{
    public Transform player;


    void Update()
    {
        if (player.eulerAngles.y < -1)
        {
            this.transform.eulerAngles = new Vector3(0,0,90);
        }
        else
        {
            this.transform.eulerAngles = new Vector3(0,0,0);
        }
    }

}//end of stript

