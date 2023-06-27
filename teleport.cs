using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public Transform Destination;       // Gameobject where they will be teleported to
	public string TagList = "|Player|Boss|Friendly|"; // List of all tags that can teleport
	public Vector3 Offset;
	public AudioSource teleportMonster;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("DestinationPortal(Clone)"))
			Destination=GameObject.Find("DestinationPortal(Clone)").transform;
	}
	public void OnTriggerEnter2D(Collider2D other)
	{
		// If the tag of the colliding object is allowed to teleport
		if (TagList.Contains(string.Format("|{0}|",other.tag))) {
			// Update other objects position and rotation
			if (other.name.Equals ("RedMonsterP(Clone)")) {
				Offset.y -= 0.3f;
			} else if (other.name.Equals ("BlueMonsterP(Clone)")) {
				Offset.x += 1.0f;
				Offset.y -= 0.3f;
			}
			else {
				Offset.y += 0.3f;
			}
			if (Destination != null)
				other.transform.position = Destination.transform.position + Offset;
			else
				Destroy (other.gameObject);
			other.gameObject.GetComponent<Movement>().speed=2;
			if (other.name.Equals("RedMonsterP(Clone)")) {
				Offset.y += 0.3f;
			}else if (other.name.Equals ("BlueMonsterP(Clone)")) {
				Offset.x -= 1.0f;
				Offset.y += 0.3f;
			} else {
				Offset.y -= 0.3f;
			}
			//other.transform.rotation = Destination.transform.rotation;
		}
		teleportMonster.Play ();
	}
}
