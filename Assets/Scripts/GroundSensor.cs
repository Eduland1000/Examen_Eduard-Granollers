using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
  {

  }
    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        PlayerScrip=GetComponentparentPlayerMovement();
    }

    void OnTriggering (BoxCollider2D collider )
    {
        isGrounded = true;
    }

     void OnTriggering (BoxCollider2D collider )
     {
        isGrounded = false;
     }

}
