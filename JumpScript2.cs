using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpScript2 : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        
         if (Ball.point_2 == true)
        {
             Invoke("Delayedfalse", 1f);
            rb.velocity = new Vector3(0, 1, 0);
        }
    }
    void Delayedfalse()
    {
        Ball.point_2 = false;
    }
}