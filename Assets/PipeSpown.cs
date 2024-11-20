using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpown : MonoBehaviour
{
    public GameObject pipe;
    public float SpownerTime = 13;
    public float timer = 0;
    public float HightOffSet = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer <SpownerTime)
        {
            timer =   timer +Time.deltaTime;
        }        
        else
        {
           SpawnPipe(); 
            timer = 0;  
        }
    }

    void SpawnPipe()
    {

        float Lowest = transform.position.y - HightOffSet;
        float Highest = transform.position.y + HightOffSet;

        Instantiate(pipe, new Vector3 (transform.position.x, Random.Range(Lowest,Highest),0), transform.rotation);
    }
}
