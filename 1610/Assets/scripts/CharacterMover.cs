﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	public CharacterController Controller;
	
	public float Gravity = 9.81f;
	public float MoveSpeed = 3.0f;
	public float JumpSpeed = 3.0f;
	
	private Vector3 position;
	private Vector3 rotation;
	
	void Start ()
	{
		Controller = GetComponent<CharacterController>();
	}
	
	void Update ()
	{

		position.x = MoveSpeed * Input.GetAxis("Horizontal");
		
		if (Controller.isGrounded)
		{
			//position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, 0);
			
			
			position = transform.TransformDirection(position);
			
			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}
		
		position.y -= Gravity * Time.deltaTime;
		Controller.Move(position * Time.deltaTime);
	}
}
