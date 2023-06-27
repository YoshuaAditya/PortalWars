using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class BaseBehaviourEndless : MonoBehaviour {

	public int Skor;
	public Text textSkor;
	public string TagList = "|Monster||laser|"; // List of all tags that can teleport
	public AudioSource takedamage;


	// Use this for initialization
	void Start () {
		Skor = 0;
	}

	// Update is called once per frame
	void Update () {
		textSkor.text = Convert.ToString (Skor);
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		// If the tag of the colliding object is allowed to teleport
		if (TagList.Contains(string.Format("|{0}|",other.tag))) {
			Destroy (other.gameObject);
			if(other.name.Contains("Lv2"))Skor+=10;
			Skor += 10;
			takedamage.Play ();
		}
	}
}
