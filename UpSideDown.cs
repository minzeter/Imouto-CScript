using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSideDown : MonoBehaviour
{ 
    private Rigidbody2D rb;
    private bool top;
    public bool _potionCheck;
    public bool _effectOn;
    [SerializeField] public float currentTime = 0f;
    [SerializeField] public float startingTime = 30f;
    
    private PlayerMovement p_Movement;
    public GameObject potion;
    public GameObject TimeCountText;
    public GameObject ObjectiveCheck;
    public Health _Health;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentTime = startingTime;
        _effectOn = false;
        TimeCountText.SetActive(false);
        //potion.SetActive(false);
    }

    void Update()
    {
        countStart();
    }

    void FixedUpdate()
    {
        check();
        checkEffect();

        if (ObjectiveCheck == null)
        {
            currentTime = 0f;
        }
        
        
    }
    
    public void check()
    {
        if (potion == null)
        {
            _potionCheck = true;
            //Debug.Log("Status:"+_potionCheck);
        }

        if (potion != null)
        {
            _potionCheck = false;
            //Debug.Log("Status:"+_potionCheck);
        }
    }

    public void countStart()
    {
        if (_potionCheck == true)
        {
            TimeStart();
        }
    }

    public void checkEffect()
    {
        if (_effectOn == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 0f);
            rb.gravityScale = 2.25f;
        }
    }

    public void TimeStart()
    {
        _effectOn = true;
        {
            if (currentTime > 0)
            {
                Effect();
                TimeCountText.SetActive(true);
                currentTime -= 1 * Time.deltaTime;
            }
            
            if (currentTime <= 0)
            {
                currentTime = 0;
                _effectOn = false;
                TimeCountText.SetActive(false);
            }
        }
    }

    
    private void Effect()
    {
        if (Input.GetKeyDown(KeyCode.E) && _Health.IsAlive == true)
        {
            rb.gravityScale *= -1;
            PlayerRotation();
        }
    }

    private void PlayerRotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        top = !top;
    }
}
