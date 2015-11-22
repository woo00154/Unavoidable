using UnityEngine;
using System.Collections;

public class Darkness : MonoBehaviour {
	private GameObject target;
	private GameObject self;
	public float velocity;

	//Constructor
	void Start(){
		target = GameObject.FindGameObjectWithTag ("Player");
		self = GameObject.Find ("Darkness");
		velocity = 0.5f;
	}

	void ChasePlayer(){
		Vector3 playerPos, selfPos, direction;
		playerPos = target.transform.position;
		selfPos = self.transform.position;
		direction = new Vector3(0,0,(playerPos - selfPos).normalized.z);

		self.GetComponent<Rigidbody> ().velocity = direction * velocity;
	}

	void OnTriggerEnter(Collider col){
		
		if (col.gameObject.tag == "Player") {

            Application.LoadLevel("MainMenu");
            Cursor.visible = !Cursor.visible;
            //gameState = endGame;
        }
	}

	void Move(Vector3 velocity){
		self.transform.Translate (velocity);
	}

	// Update is called once per frame
	void Update () {
		if (target != null)
			ChasePlayer ();
		velocity += 0.002f;
	}
}
