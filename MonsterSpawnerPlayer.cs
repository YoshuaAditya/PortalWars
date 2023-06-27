using UnityEngine;
using System.Collections;

public class MonsterSpawnerPlayer : MonoBehaviour {

	public Vector3 Offset;	
//	private float spawnTime;
//	private MeshRenderer mesh;
	private GameObject copy;
	private double y;
	private float xOff = -7.3f;
	// Use this for initialization
	void Start () {
//		spawnTime = GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().spawnTime;
		for (int i = 0; i < 3; i++) {
			y = Random.value;
			Vector3 newPos=new Vector3(xOff,3.85f,1.5f);
			if (y < 0.34) {
				copy = GameObject.Instantiate (GameObject.Find ("RedMonsterP"));
				newPos=new Vector3(xOff+0.5f,4.1f,1.5f);
			} else if (y < 0.67) {
				copy = GameObject.Instantiate (GameObject.Find ("BlueMonsterP"));
				newPos=new Vector3(xOff+2,4.0f,1.5f);
			} else {
				copy = GameObject.Instantiate (GameObject.Find ("GreenMonsterP"));
				newPos=new Vector3(xOff+0.2f,4.6f,1.5f);
			}

			copy.transform.position = newPos;
			copy.GetComponent<Movement> ().speed = 0;
			//mesh= copy.GetComponent<MeshRenderer> ();
			//mesh.enabled = !mesh.enabled;
			xOff += 2.3f;
		}
		xOff=-7.3f;
		for (int i = 0; i < 3; i++) {
			y = Random.value;
			Vector3 newPos=new Vector3(xOff,3.85f,1.5f);
			if (y < 0.34) {
				copy = GameObject.Instantiate (GameObject.Find ("RedMonsterP"));
				newPos=new Vector3(xOff+0.5f,2.1f,1.5f);
			} else if (y < 0.67) {
				copy = GameObject.Instantiate (GameObject.Find ("BlueMonsterP"));
				newPos=new Vector3(xOff+2,2.0f,1.5f);
			} else {
				copy = GameObject.Instantiate (GameObject.Find ("GreenMonsterP"));
				newPos=new Vector3(xOff+0.2f,2.6f,1.5f);
			}

			copy.transform.position = newPos;
			copy.GetComponent<Movement> ().speed = 0;
			//mesh= copy.GetComponent<MeshRenderer> ();
			//mesh.enabled = !mesh.enabled;
			xOff += 2.3f;
		}
		this.gameObject.GetComponent<MonsterSpawnerPlayer> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {

			
			//mesh= copy.GetComponent<MeshRenderer> ();
			//mesh.enabled = !mesh.enabled;
//		}

	}
	public void spawn(){
		y = Random.value;
		if (y < 0.34) {
			copy = GameObject.Instantiate (GameObject.Find ("RedMonsterP"));
			Offset.x += 0.7f;
			Offset.y -= 0.3f;
		} else if (y < 0.67) {
			copy = GameObject.Instantiate (GameObject.Find ("BlueMonsterP"));
			Offset.x += 2.0f;
			Offset.y -= 0.3f;
		} else {
			copy = GameObject.Instantiate (GameObject.Find ("GreenMonsterP"));
			Offset.x += 0.3f;
			Offset.y += 0.3f;
		}
		copy.transform.position = Offset;
		copy.GetComponent<Movement> ().speed = 0;
		if (y < 0.34) {
			Offset.x -= 0.7f;
			Offset.y += 0.3f;
		} else if (y < 0.67) {
			Offset.x -= 2.0f;
			Offset.y += 0.3f;
		} else {
			Offset.x -= 0.3f;
			Offset.y -= 0.3f;
		}
	}
}
