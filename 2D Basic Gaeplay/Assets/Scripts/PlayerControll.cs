using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float PlayerSpeed = 15;
    public float OutOfBounds = 8;
    private float _horizontalInput;
    // im peeing my pants 
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * _horizontalInput * PlayerSpeed * Time.deltaTime);

        if(transform.position.x > OutOfBounds)
        {
            transform.position = new Vector3(OutOfBounds, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -OutOfBounds )
        {
            transform.position = new Vector3(-OutOfBounds, transform.position.y, transform.position.z);
        }
    }

}
