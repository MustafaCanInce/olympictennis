using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpScript : MonoBehaviour
{
    private AudioSource _audioSource;
    public float speed = 10f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Ball.point_1 == true)
        {
            Invoke("Delayedfalse1", 1f);
            rb.velocity = new Vector3(0, 1, 0);
            _audioSource.Play();
        }
        
    }
    void Delayedfalse1()
    {
        Ball.point_1 = false;
    }
}