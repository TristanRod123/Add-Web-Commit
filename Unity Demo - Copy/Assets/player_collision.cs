using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c)
    {
        if(Equals(c.gameObject.tag,"wall"))
        {
            Debug.Log("PLayer hit a wall...what should we do?");

            //Player loses hp
            //Level was restarted
            //Spawn more enemies
        }
    }
}
