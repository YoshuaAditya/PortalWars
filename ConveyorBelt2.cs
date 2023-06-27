using UnityEngine;
using System.Collections;

public class ConveyorBelt2 : MonoBehaviour {
	public float sped = 2.0f;
	public int count = 0;
	public Vector3 offset1;
	// Use this for initialization
	void Start () {
	}
	void Update(){
		if (this.count < 3) {
			GameObject.Find("Base").gameObject.GetComponent<MonsterSpawnerPlayer> ().enabled = true;
			GameObject.Find ("Base").gameObject.GetComponent<MonsterSpawnerPlayer> ().Offset = offset1;
		}
		else {
			GameObject.Find("Base").gameObject.GetComponent<MonsterSpawnerPlayer> ().enabled = false;
		}
	}

	public void OnTriggerEnter2D(Collider2D other){
		count++;
	}
	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag != "Monster")
			return;

		// Assign velocity based upon direction of conveyor belt
		// Ensure that conveyor mesh is facing towards its local Z-axis

		//float conveyorVelocity = speed * Time.deltaTime;

		other.gameObject.GetComponent<Movement> ().speed = sped;
		//Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();
		//rigidbody.velocity = conveyorVelocity * transform.forward;
	}
	public void OnTriggerExit2D(Collider2D other)
	{
		count--;
	}
}
