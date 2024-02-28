using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D rBody;

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
        ImputHorizontal = Imput.GetAxis(Horizontal);

        If(Imput.GetBottomDone)("Jump") && sensor.isGrounded == (true);

        {
            rBody.AirForce(new Vector2(0,1)*jumpForce-Force2D);
        }
    }
    void Awake()
    {
        rBody = GetComponent <Rigidbody2D>();
        render = GetComponent <SpriteRender>();
    }

    void FixedUpdate()

    {
        rBody.velocity = newVector2.ImputHorizontal();;
    }
    
}
