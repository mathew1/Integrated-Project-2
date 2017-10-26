﻿using UnityEngine;
using System.Collections;

public class UserBlockDestroy : MonoBehaviour {

	//public DrlBtnScr drillerButton;
	public UserBlockCreate blockCreation;
	public Blk1BtnScr block1Button;
	//public Blk2BtnScr block2Button;
	public AudioClip BlockDestroySound;

		
	// Use this for initialization
	void Start () {
	
	//drillerButton = GameObject.FindWithTag("DrillerButton").GetComponent<DrlBtnScr>();
	blockCreation = GameObject.FindWithTag("Background").GetComponent<UserBlockCreate>();
	block1Button = GameObject.FindWithTag ("Block1Button").GetComponent<Blk1BtnScr>();
	//	block2Button = GameObject.FindWithTag ("Block2Button").GetComponent<Blk2BtnScr> ();

	

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown (1)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection(ray,Mathf.Infinity);
			audio.PlayOneShot(BlockDestroySound);
			
			if(hit.collider != null && hit.collider.transform == this.transform && hit.collider.tag == "Block1")
			{
				Destroy (this.gameObject);

				if(blockCreation.block1Counter < 10){

					blockCreation.block1Counter++;

				}
				Debug.Log("Block 1 Count:" + blockCreation.block1Counter);
				if(blockCreation.block1Counter == 10){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritexi10;
					
				}
				
				else if(blockCreation.block1Counter == 9){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex9;
					
				}
				else if(blockCreation.block1Counter == 8){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex8;
					
				}
				else if(blockCreation.block1Counter == 7){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex7;
					
				}
				else if(blockCreation.block1Counter == 6){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex6;
					
				}
				else if(blockCreation.block1Counter == 5){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex5;
					
				}
				else if(blockCreation.block1Counter == 4){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex4;
					
				}
				else if(blockCreation.block1Counter == 3){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex3;
					
				}
				else if(blockCreation.block1Counter == 2){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex2;
					
				}
				else if(blockCreation.block1Counter == 1){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex1;
					
				}
				else if(blockCreation.block1Counter == 0){
					
					block1Button.spriteRenderer.sprite = block1Button.block1Spritex0;
					
				}

			}



			if(hit.collider != null && hit.collider.transform == this.transform && hit.collider.tag == "DestroyableBuilding")
			{
				Destroy (this.gameObject);
				Debug.Log("Building Destroyed");
			}

			//if(hit.collider != null && hit.collider.transform == this.transform)
			//{
			//	Destroy (this.gameObject);
			//}
		}


	}
}
