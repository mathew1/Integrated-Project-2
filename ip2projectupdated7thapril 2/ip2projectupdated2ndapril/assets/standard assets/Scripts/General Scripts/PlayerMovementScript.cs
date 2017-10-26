using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	public float speed;
	public float jumpForce;
    private bool isGrounded=true;
	//public UserBlockCreate blockCreation;
	public int finalPiece;
	//Sounds
	public AudioClip JumpSound;
	public AudioClip PickupSound;
	public AudioClip NoPickupSound;
	public AudioClip CheeringSound;
	public Blk1BtnScr block1Button;
	public Blk2BtnScr block2Button;
	public Animator anim;
	public Transform cameraCurrent;
	public Transform SpawnPoint;
	public GameObject player;
	// Use this for initialization
	void Start () {

    
		Physics2D.IgnoreLayerCollision(9,8);
	//blockCreation = GameObject.FindWithTag("Background").GetComponent<UserBlockCreate>();
		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {


		float axisValue=Input.GetAxis("Horizontal");
		anim.SetFloat("speed", Mathf.Abs(axisValue));

    rigidbody2D.fixedAngle = true;
	
    if(Input.GetAxisRaw("Horizontal")> 0){
    
			Vector3 scale=cameraCurrent.localScale;
            transform.Translate (Vector3.right * speed * Time.deltaTime);
			transform.localScale=new Vector3(1.0f,1.0f,1.0f);
			cameraCurrent.localScale=scale;
			//transform.eulerAngles = new Vector2(0, 0);
    }
    if(Input.GetAxisRaw("Horizontal")< 0){
    
			Vector3 scale=cameraCurrent.localScale;
			transform.Translate (Vector3.right * -speed * Time.deltaTime);
			transform.localScale=new Vector3(-1.0f,1.0f,1.0f);
			cameraCurrent.localScale=scale;
			//transform.eulerAngles = new Vector2(0,180);
			//camera.eulerAngles = new Vector2(0, -180);
    }
    if(((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown (KeyCode.Space))) && (isGrounded == true)){
    
        
        rigidbody2D.AddForce (new Vector2(0,jumpForce));
			audio.PlayOneShot(JumpSound);
			anim.SetTrigger("jump");
			isGrounded = false;
    

    }
}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "platformFixed"){
        
        	Debug.Log("Player landed.");
			//rigidbody2D.isKinematic = true;
        	isGrounded = true;
        
    	}

		if (collision.gameObject.tag == "Block1" || collision.gameObject.tag == "Block2") {

			Debug.Log ("Player landed.");
			isGrounded = true;

		}

		if (collision.gameObject.tag == "die") {
			
			Debug.Log ("Player died.");

			Application.LoadLevel(Application.loadedLevel);
			
		}

	

		if (collision.gameObject.tag == "Complete"){

			audio.PlayOneShot(CheeringSound);
		}

		if (collision.gameObject.tag == "Next Level") {
			
			Debug.Log ("Player Successful.");
			
			Application.LoadLevel("JamieLevel1");
			
		}

		if (collision.gameObject.tag == "FinalBuildPiece") {
			
			GameObject.Find ("Background").GetComponent<UserBlockCreate>().block1Counter++;
			Debug.Log ("Pieces collected: " + finalPiece);
			audio.PlayOneShot(PickupSound);
			Destroy (collision.gameObject);
			
			
		}

		/*if(collision.gameObject.tag == "BacktoLevelSelect"){

			audio.Play ();
			if(CheeringSound.isPlaying == false){

			
			Application.LoadLevel("LevelSelect");
			} 
		} */

		
	}



}






