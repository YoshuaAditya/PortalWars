using UnityEngine;
using System.Collections;

public class UIGameDecision : MonoBehaviour {	
	// Use this for initialization
	public GameObject BasePlayer, BaseEnemy;
	public GameObject WinPanel, LosePanel;
	private BaseBehaviour BaseHPPlayer, BaseHPEnemy;
	private int currentHPPLayer, currentHPEnemy;
	public AudioSource win, lose, ingame;
	private bool cek;
	// Use this for initialization
	void Start () {
		BaseHPPlayer = BasePlayer.GetComponent<BaseBehaviour> ();
		BaseHPEnemy = BaseEnemy.GetComponent<BaseBehaviour>();
		cek = true;
	}

	void Awake(){
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update () {
		currentHPPLayer = BaseHPPlayer.Health;
		currentHPEnemy = BaseHPEnemy.Health;
		cekState ();
	}

	public void backtoGame(){
		Time.timeScale = 1;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy>().enabled = true;
	}

	public void cekState(){		
//		print ("HP Player = "+currentHPPLayer);
//		print ("HP Enemy = "+currentHPEnemy);
		if (currentHPPLayer <= 0) {
			currentHPPLayer = 0;
//			print ("You're Lose");
			Time.timeScale = 0;
			GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = false;
//			GameObject[] n = GameObject.FindGameObjectsWithTag ("Monster");
//			foreach (GameObject t in n) {
//				t.GetComponent<Movement> ().enabled = false;
//			}
			if (cek) {
				LosePanel.SetActive (true);
				ingame.Pause ();
				lose.Play ();
				cek = false;
			}
		}else if (currentHPEnemy <= 0) {
			currentHPEnemy = 0;
//			print ("You're Win");
			Time.timeScale = 0;
			GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy>().enabled = false;
//			GameObject[] n = GameObject.FindGameObjectsWithTag ("Monster");
//			foreach (GameObject t in n) {
//				t.GetComponent<Movement> ().enabled = false;
//			}
			if (cek) {
				WinPanel.SetActive (true);
				ingame.Pause ();
				win.Play ();
				cek = false;
			}
		}
	}
}
