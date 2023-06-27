using UnityEngine;
using System.Collections;

public class laserBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        // If the tag of the colliding object is allowed to teleport
        if (other.gameObject.CompareTag("Monster"))
        {
            Destroy(other.gameObject);
        }
    }
}
