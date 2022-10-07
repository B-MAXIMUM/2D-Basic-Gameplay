using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiBoobs : MonoBehaviour
{
    public float topBound;
    public float lowerBound;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > topBound)
        {
            Destroy(this.gameObject);
        }
        if(transform.position.y < lowerBound)
        {
            Debug.Log("game over an enemt got past you.");
            Destroy(this.gameObject);
        }
    }
}
