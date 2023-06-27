using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public string TagList = "|Monster||laser|";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter2D(Collider2D other)
	{
		// If the tag of the colliding object is allowed to teleport
		if (TagList.Contains(string.Format("|{0}|",other.tag))) {
			Destroy (other.gameObject);
		}
	}
}
