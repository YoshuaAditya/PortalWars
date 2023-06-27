using UnityEngine;
using System.Collections;

public class PanelDecision : MonoBehaviour {

	private string loadLevel;
	private int random;
	private GameObject monster;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		loadLevel = Scenes.getParam ("LevelPanel");
		if (loadLevel.Equals ("active")) {
			GameObject.Find ("MainMenuPanel").SetActive (false);
			findincativegameobject ("MainMenu", "LevelPanel").SetActive(true);
			Scenes.getSceneParameters () [loadLevel] = "inactive";
		}
		random = Random.Range (1, 6);
		switch (random) {
		case 1:
			monster = findincativegameobject ("Monsters", "BlueMonsterPLv2");
			break;
		case 2:
			monster = findincativegameobject ("Monsters", "GreenMonsterPLv2");
			break;
		case 3:
			monster = findincativegameobject ("Monsters", "RedMonsterPLv2");
			break;
		case 4:
			monster = findincativegameobject ("Monsters", "BlueMonsterP");
			break;
		case 5:
			monster = findincativegameobject ("Monsters", "GreenMonsterP");
			break;
		case 6:
			monster = findincativegameobject ("Monsters", "RedMonsterP");
			break;
		}
		monster.SetActive (true);
	}

	GameObject findincativegameobject(string nameParent, string nameObject){
		Transform[] trans = GameObject.Find (nameParent).GetComponentsInChildren<Transform> (true);
		foreach(Transform t in trans){
			if(t.gameObject.name.Equals(nameObject)){
				return t.gameObject;
			}
		}
		return null;
	}


	public void toExit()
	{
		Application.Quit ();
	}


	
	// Update is called once per frame
	void Update () {

	}
}
