using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // to make it the the player doesn't get to spam multiple dogs i created a cooldown variable
    private float coolDown = 1;
    // it's a 1 second cool down variable


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog and check if cooldown is <= 0 
        if (Input.GetKeyDown(KeyCode.Space) && coolDown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolDown = 1;
        }
        if (coolDown >= 0)
        {
            coolDown -= Time.deltaTime;
        }
    }
}
