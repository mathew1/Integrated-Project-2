using UnityEngine;
using System.Collections;

public class GoldMedal : MonoBehaviour {


	public AudioClip CheeringSound;
	private float timeP;
	private bool isInside;

	IEnumerator Start()
	{
		isInside = false;
		yield return StartCoroutine(CoUpdate());
		yield return null;
	}

	//Once per sec
	IEnumerator CoUpdate()
	{
		//Kinda like start

		//Once per frame
		while(true)
		{
			if(isInside)
				yield return StartCoroutine(CheerLevel());

			yield return null;
		}
		yield return null;
	}

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D trigger) {

		if (trigger.gameObject.tag == "Player"){
			Debug.Log("parrot");
			isInside = true;

		}
	}

	private IEnumerator CheerLevel()
	{
		AudioSource.PlayClipAtPoint(CheeringSound, GameObject.Find("Player 1").transform.position);
		yield return new WaitForSeconds(5);
		Application.LoadLevel("LevelSelect");
		yield return null;
	}

}
