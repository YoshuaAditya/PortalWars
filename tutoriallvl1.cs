using UnityEngine;
using System.Collections;

public class tutoriallvl1 : MonoBehaviour {


	public GameObject tutorial1, tutorial2, tutorial3;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		StartCoroutine (tutorial());
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
		//		}
		//		if (Time.frameCount == 180) {
		yield return new WaitForSecondsRealtime(5);
		tutorial1.SetActive (false);
		Time.timeScale = 1;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = true;
		//		}
		//		if (Time.frameCount == 230) {
		yield return new WaitForSecondsRealtime(5);
		tutorial2.SetActive (true);
		Time.timeScale = 0;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = false;
		//		}
		//		if (Time.frameCount == 300) {
		yield return new WaitForSecondsRealtime(5);
		tutorial2.SetActive (false);
		Time.timeScale = 1;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = true;
		//		}
		//		if (Time.frameCount == 330) {
		yield return new WaitForSecondsRealtime(5);
		tutorial3.SetActive (true);
		Time.timeScale = 0;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = false;
		//		}
		//		if (Time.frameCount == 400) {
		yield return new WaitForSecondsRealtime(5);
		tutorial3.SetActive (false);
		Time.timeScale = 1;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = true;
		//		}
	}
}
