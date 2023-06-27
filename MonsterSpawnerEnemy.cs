using UnityEngine;
using System.Collections;

public class MonsterSpawnerEnemy : MonoBehaviour {

	public Vector3 Offset;
	public float spawnTime, speed;
	private MeshRenderer mesh;
	private GameObject copy;
	private double y;
	public AudioSource teleportMonster;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Time.frameCount % spawnTime == 0) {//spawn time

			y = Random.value;
			if (y < 0.34) {
				Offset.x = 5;
				Offset.y = -0.27f;//offset y lane 1
			} else if (y < 0.67) {
				Offset.x = 5;
				Offset.y = -1.99f;//offset y lane 2
			} else {
				Offset.x = 5;
				Offset.y = -3.76f;//offset y lane 3
			}

			y = Random.value;
			if (y < 0.34) {
				copy = GameObject.Instantiate (GameObject.Find ("RedMonsterE"));
				Offset.y -= 0.3f;
			} else if (y < 0.67) {
				copy = GameObject.Instantiate (GameObject.Find ("BlueMonsterE"));
				Offset.y -= 0.3f;
			} else {
				copy = GameObject.Instantiate (GameObject.Find ("GreenMonsterE"));
				Offset.y += 0.3f;
			}



				

			copy.transform.position = Offset;
			copy.GetComponent<Movement> ().speed = speed;//speed
			teleportMonster.Play ();
			//mesh= copy.GetComponent<MeshRenderer> ();
			//mesh.enabled = !mesh.enabled;
		}
	}
}
