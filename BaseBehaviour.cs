using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BaseBehaviour : MonoBehaviour {

	private int health;
	private int maxHealth;
	public string TagList = "|Monster||laser|"; // List of all tags that can teleport
	private HPbar bar;
	public Image barHP;
	public AudioSource takedamage;

	// Use this for initialization
	void Start () {
		maxHealth = 200;
		health = maxHealth;
		bar = new HPbar (barHP, maxHealth);
	}
	
	// Update is called once per frame
	void Update () {
		/*if (GameObject.Find("Base").GetComponent<BaseBehaviour>().health <= 0) {
			Application.LoadLevel ("Lose");
		}
		else if (GameObject.Find("Base1").GetComponent<BaseBehaviour>().health <= 0) {
			Application.LoadLevel ("Win");
		}*/
		bar.updateHPbar (health);
	}

	public int Health {
		get {
			return health;
		}
		set {
			health = value;
		}
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		// If the tag of the colliding object is allowed to teleport
		if (TagList.Contains(string.Format("|{0}|",other.tag))) {
			Destroy (other.gameObject);
			if(other.name.Contains("Lv2"))health-=10;
			health -= 10;
			takedamage.Play ();
		}
	}
}
