using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public Rigidbody rb;
    public float tekanan = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            rb.Addbatasan(0, 0, tekanan);
        }
        
    }
}
