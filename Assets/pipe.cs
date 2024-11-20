using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float MoveSpeed = 2 ;
    private float DeadZone = -40;
   
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;

        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
      
    }
}
