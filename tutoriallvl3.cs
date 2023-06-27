using UnityEngine;
using System.Collections;

public class tutoriallvl3 : MonoBehaviour {

	public GameObject tutorial1, tutorial2, tutorial3;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		StartCoroutine (tutorial ());
	}

	// Update is called once per frame
	void Update () {
//		
	}

	IEnumerator tutorial(){
		yield return new WaitForSecondsRealtime(1);
		tutorial1.SetActive (true);
		Time.timeScale = 0;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = false;
		GameObject.Find ("laser").GetComponent<PowerupLaser> ().enabled = false;
		GameObject.Find ("health").GetComponent<PowerupHealth> ().enabled = false;
		//		}
		//		if (Time.frameCount == 250) {
		yield return new WaitForSecondsRealtime(5);
		tutorial1.SetActive (false);
		Time.timeScale = 1;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = true;
		GameObject.Find ("laser").GetComponent<PowerupLaser> ().enabled = true;
		GameObject.Find ("health").GetComponent<PowerupHealth> ().enabled = true;
		//		}
		//		if (Time.frameCount == 500) {
		yield return new WaitForSecondsRealtime(5);
		tutorial2.SetActive (true);
		Time.timeScale = 0;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = false;
		GameObject.Find ("laser").GetComponent<PowerupLaser> ().enabled = false;
		GameObject.Find ("health").GetComponent<PowerupHealth> ().enabled = false;
		//		}
		//		if (Time.frameCount == 600) {
		yield return new WaitForSecondsRealtime(5);
		tutorial2.SetActive (false);
		Time.timeScale = 1;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = true;
		GameObject.Find ("laser").GetComponent<PowerupLaser> ().enabled = true;
		GameObject.Find ("health").GetComponent<PowerupHealth> ().enabled = true;
		//		}
		//		if (Time.frameCount == 1500) {
		yield return new WaitForSecondsRealtime(5);
		tutorial3.SetActive (true);
		Time.timeScale = 0;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = false;
		GameObject.Find ("laser").GetComponent<PowerupLaser> ().enabled = false;
		GameObject.Find ("health").GetComponent<PowerupHealth> ().enabled = false;
		//		}
		//		if (Time.frameCount == 1550) {
		yield return new WaitForSecondsRealtime(5);
		tutorial3.SetActive (false);
		Time.timeScale = 1;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = true;
		GameObject.Find ("laser").GetComponent<PowerupLaser> ().enabled = true;
		GameObject.Find ("health").GetComponent<PowerupHealth> ().enabled = true;
		//		}
	}
}
