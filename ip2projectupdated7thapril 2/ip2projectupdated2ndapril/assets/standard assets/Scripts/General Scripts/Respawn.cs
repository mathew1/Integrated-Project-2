using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D collision){

			if(collision.gameObject.tag == "Player 1")

				player.transform.position = SpawnPoint.position;
		}



	}

