﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	public Sprite dmgSprite;
	// Sprite after player hits wall
	public int hp = 4;



	private SpriteRenderer spriteRenderer; 

	// starts any variables or game state before the game starts
	void Awake () 
	{
		spriteRenderer = GetComponent<SpriteRenderer>();

		
	}
	
	public void DamageWall (int loss)
	{
		spriteRenderer.sprite = dmgSprite;
		hp -= loss;
		if (hp <= 0)
			gameObject.SetActive(false);
	}
}
