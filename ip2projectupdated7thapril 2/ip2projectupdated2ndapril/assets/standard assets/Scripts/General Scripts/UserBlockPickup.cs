using UnityEngine;
using System.Collections;

public class UserBlockPickup : MonoBehaviour {

	public UserBlockCreate blockCreation;
	public Blk1BtnScr block1Button;


	// Use this for initialization
	void Start () {
		blockCreation = GameObject.FindWithTag("Background").GetComponent<UserBlockCreate>();
		block1Button = GameObject.FindWithTag ("Block1Button").GetComponent<Blk1BtnScr>();
	

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D collision) {

		if (collision.gameObject.tag == "FinalBuildPiece"){

			Destroy (collider.gameObject);
		
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
	
	
	}
	}

	





