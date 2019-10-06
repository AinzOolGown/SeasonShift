using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public Transform bullet;
    public float Yvelocity; 
    public float Xvelocity;


    // Update is called once per frame
    void Update()
    {
        //movement on the y axis relative to the rotation of the object
        transform.position += transform.up * Time.deltaTime * Yvelocity;

        //movement on the x axis relative to the rotation of the object
        transform.position += transform.right * Time.deltaTime * Xvelocity;
    
    }
}
