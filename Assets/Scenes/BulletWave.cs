using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWave : MonoBehaviour
{
    public float timeDelay = 0.0f;
    public GameObject box;  //object you want spawned goes in here
    public float xAxis = 0.0f;  // Determines where it will spawn in the x axis
    public float yAxis = 0.0f;  // Determines where it will spawn in the y axis
    public float zRotation = 0.0f;  // Rotation counter clockwise 
    
    private float xRotation = 0.0f;  
    private float yRotation = 0.0f;
    private float amTime = 0.0f; 
    


    void Start()
    {
        StartCoroutine("Timer");
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(timeDelay);
        Quaternion angle = Quaternion.Euler(xRotation,yRotation,zRotation); // creating angle variable for object
        Vector3 postition = new Vector3(xAxis,yAxis,0.0f);  // creating position variable for object

        Debug.Log("Its here"); //check to see if it works

        Instantiate(box, postition, angle);

    }

    // Update is called once per frame
    void Update()
    {
        amTime = amTime + Time.deltaTime;       
        
    }
}
