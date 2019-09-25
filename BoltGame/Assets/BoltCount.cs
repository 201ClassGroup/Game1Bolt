using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltCount : ObjectShooter
{

    public int maxBolts;
    int boltCount;
    public ObjectShooter shooterScript;

    // Start is called before the first frame update
    void Start()
    {
        boltCount = 0;
    }

    // Update is called once per frame
    public override void Update()
    {

        if (Input.GetKey(keyToPress)
           && Time.time >= timeOfLastSpawn + creationRate && (boltCount < maxBolts))
        {
            Vector2 actualBulletDirection = (relativeToRotation) ? (Vector2)(Quaternion.Euler(0, 0, transform.eulerAngles.z) * shootDirection) : shootDirection;

            GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
            newObject.transform.position = this.transform.position;
            newObject.transform.eulerAngles = new Vector3(0f, 0f, Utils.Angle(actualBulletDirection));
            //newObject.tag = "Bolt";

            // push the created objects, but only if they have a Rigidbody2D
            Rigidbody2D rigidbody2D = newObject.GetComponent<Rigidbody2D>();
            if (rigidbody2D != null)
            {
                rigidbody2D.AddForce(actualBulletDirection * shootSpeed, ForceMode2D.Impulse);
            }

            // add a Bullet component if the prefab doesn't already have one, and assign the player ID
            BulletAttribute b = newObject.GetComponent<BulletAttribute>();
            if (b == null)
            {
                b = newObject.AddComponent<BulletAttribute>();
            }
            b.playerId = playerNumber;

            boltCount++;

            timeOfLastSpawn = Time.time;
        }
    }

    public void CollectBolt()
    {
        boltCount--;
    }

}// end of class
