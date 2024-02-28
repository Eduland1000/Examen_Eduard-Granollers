using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody 2D rBody;

    public float jumpForce = 4;

    public float movementSpeed = 8;

    public bool jump = false;

    public SpriteRenderer render;

    public float ImputHoizontal;

    public GroundSensor sensor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ImputHorizontal = Imput.GetAxis(Horizontal)
    }
    void Awake
    {
        
    }
}
