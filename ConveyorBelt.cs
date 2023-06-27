using UnityEngine;
using System.Collections;

public class ConveyorBelt : MonoBehaviour {

	public float sped = 2.0f;
	public Vector3 offset1;
	// Use this for initialization
	void Start () {
	}
	void Update(){
		
	}
	public void OnTriggerEnter2D(Collider2D other){
		
	}
	public void OnTriggerStay2D(Collider2D other)
	{
		
		// Assign velocity based upon direction of conveyor belt
		// Ensure that conveyor mesh is facing towards its local Z-axis

		//float conveyorVelocity = speed * Time.deltaTime;
		if (other.gameObject.GetComponent<Movement> () != null) {
			other.gameObject.GetComponent<Movement> ().speed = sped;
		}
		//Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();
		//rigidbody.velocity = conveyorVelocity * transform.forward;
	}
	public void OnTriggerExit2D(Collider2D other)
	{
		if (!other.gameObject.CompareTag ("Meteor")) {
			GameObject.Find ("Base").gameObject.GetComponent<MonsterSpawnerPlayer> ().Offset = offset1;
			GameObject.Find ("Base").gameObject.GetComponent<MonsterSpawnerPlayer> ().spawn ();
		}
	}

}
