using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]public float moveSpeed;

    [SerializeField] public float groundDrag;

    [Header("Ground Cheak")]
    [SerializeField] public float playerHeight;
    //public LayerMask gg;
    //bool grounded;

    [Header("Cam")]
    public GameObject Camera;

    [Header("Sound")]
    public AudioSource AudioSource;
    public AudioSource AudioSource02;

    [Header("Stamina")]
    public float stamina;
    float maxStamina;
    public Slider staminaBar;
    public float dValue;
   

    

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;
    
   
    Rigidbody rb;


   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        AudioSource.GetComponent<AudioSource>();
        maxStamina = stamina;
        staminaBar.maxValue = maxStamina;
    }
    // Update is called once per frame
    void Update()
    {
        rb.drag = groundDrag;
        MyInput();
        // grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, gg);
        // if (grounded)
        // {
        //     Debug.Log("1");
        //rb.drag = groundDrag;
        // }
        // else //rb.drag = 0;
        // Debug.Log("2");
        SpeedControl();
        staminaBar.value = stamina;
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            AudioSource.Stop();
        }






    }
     

    private void FixedUpdate()
    {
        Moveplayer();
        
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        
    }
    private void Moveplayer()
    {  //walk system
         moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized*moveSpeed*10f,ForceMode.Force);

        if (moveDirection.magnitude <= 0 && moveSpeed == 4)
            {
            if(Time.timeScale == 1)
            AudioSource.Play();
            
          

        }
        
         //-------------------------------------------------------------------------------------------------------------
        //runInput system
       /* if (Input.GetKey(KeyCode.LeftShift) && moveSpeed > 0 && moveDirection.magnitude > 0)
                DecreaseEnergy();
        else if(stamina != maxStamina)
                    IncreaseEnergy();

        if (Input.GetKey(KeyCode.LeftShift)&& moveSpeed> 0 && moveDirection.magnitude > 0)
        {
            if (moveSpeed == 3 && staminaBar.value > 0)
            {
                
                StartWalk();
                moveSpeed = moveSpeed + 1;
                  
                  AudioSource.Stop();
                 AudioSource02.Play();
                

                /*if (orientation.transform.position != lastpos)
                {
                    moveSpeed = moveSpeed - 2;
                    Stopsit();
                    AudioSource02.Stop();
                }
                else Debug.Log("2");
                lastpos = orientation.transform.position;*//*

            } 
            if(staminaBar.value == 0)
            {
               
                moveSpeed = 3;
                StopsAnimation();
                AudioSource02.Stop();

                if (moveDirection.magnitude > 0)
                {
                    AudioSource.Play();
                }
            }
          
            
        } 
       
        if (Input.GetKeyUp(KeyCode.LeftShift) && moveSpeed > 3)
            {
                moveSpeed = moveSpeed - 1;
            StopsAnimation();
            AudioSource02.Stop();
           
            if (moveDirection.magnitude > 0)
            {
                AudioSource.Play();             
            }
        }*/

        
       
        //-------------------------------------------------------------------------------------------------------------
        //CrouchSystem
        if (Input.GetKeyDown(KeyCode.LeftControl) && moveSpeed == 4)
        {
            if (moveSpeed == 4)
            {
                moveSpeed = moveSpeed - 2;
            }
            StopsAnimation();
            Startsit();
           
            AudioSource.Stop();
        }
        if (Input.GetKeyUp(KeyCode.LeftControl) && moveSpeed < 4)
        {
            moveSpeed = moveSpeed + 2;
            StopsAnimation();

            if (moveDirection.magnitude > 0 && moveSpeed == 4)
            {
                AudioSource.Play();
            }
        }
        //-------------------------------------------------------------------------------------------------------------
    }
    private void SpeedControl()
    {
        Vector3 fletvel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(fletvel.magnitude > moveSpeed)
        {
            Vector3 limitvel = fletvel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitvel.x, rb.velocity.y, limitvel.z);
        }
    }
    
    private void StartWalk()
    {
        Camera.GetComponent<Animator>().Play("HeadBobby");
    }
    private void Startsit()
    {
        Camera.GetComponent<Animator>().Play("sit");
       
    }
  
    private void StopsAnimation()
    {
        Camera.GetComponent<Animator>().Play("New State");
    }


    private void DecreaseEnergy()
    {
        if(staminaBar.value != 0)
        {
            stamina -= dValue * Time.deltaTime;
        }
    }
    private void IncreaseEnergy()
    {
            stamina += dValue * Time.deltaTime;
    }

}

