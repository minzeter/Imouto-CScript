using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public float runSpeed = 100f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	public Animator animator;
	private string currentState;
	public Health _Health;

	const string Run = "Run";
	const string Idel = "Idel";
	const string Jump = "Player_Jump";
	const string Death = "Death";
	
	
	void ChangeAnimationState(string newState)
	{
		if (currentState == newState) return;
		
		animator.Play(newState);
	}

	// Update is called once per frame
	void Update () {

		if (_Health.IsAlive == true)
		{

			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

			//animator.SetFloat("Speed", Mathf.Abs(horizontalMove) );

			if (Input.GetButtonDown("Jump"))
			{
				jump = true;
				//animator.SetBool("IsJumping",true);
			}

			if (horizontalMove != 0)
			{
				ChangeAnimationState(Run);
			}
			else
			{
				ChangeAnimationState(Idel);
			}
		}

		if (_Health.IsAlive == false)
		{
			horizontalMove = 0;
		}
	}

	void FixedUpdate()
	{
		if (_Health.IsAlive == true)
		{
			// Move our character
			controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
			jump = false;

		}
	}
}
