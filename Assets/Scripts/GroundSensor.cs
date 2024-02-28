using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public is Grounded

    Playermovement is lit


    // Start is called before the first frame update
    void Start()
  
    // Update is called once per frame
    void Update()
    {}

    void Awake
    {
        (PlayerScrip = GetComponent parent PlayerMovement)
    }

    void OnTriggering (BoxCollide2D collider )
    {
        isGrounded = true;
    }

     void OnTriggering (BoxCollide2D collider )
     {
        isGrounded = false;
     }

}
