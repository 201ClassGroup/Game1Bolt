using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTurnScript : MonoBehaviour
{
    public Transform player;
    public Transform shooterPos;
    public BoltCount shooter;


    void Update()
    {

        if (player.rotation.y <= (-180))
        {
            Debug.Log("Facing left");
            Debug.Log(this.transform.eulerAngles);
            //shooter.shootDirection.Set(-1 , 1);
        }
        else //if (player.eulerAngles.y > -180)
        {

            Debug.Log("Facing right");
        }
        
    }

}//end of stript

