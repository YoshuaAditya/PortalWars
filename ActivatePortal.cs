using UnityEngine;
using System.Collections;

public class ActivatePortal : MonoBehaviour {
	public float sped;
	private GameObject copy;
	public AudioSource portalbuka, portaltutup;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if ( Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit=Physics2D.Raycast (ray.origin,ray.direction);
			if (hit) {
				if (hit.transform.gameObject.CompareTag ("InactiveSource")) {
					portalbuka.Play ();
					Destroy (GameObject.Find ("SourcePortal(Clone)"));
					if (hit.transform.gameObject.name.Equals ("InactiveSourcePortal1")) {
						GameObject.Find ("Belt1").GetComponent<ConveyorBelt> ().sped = sped;
						GameObject.Find ("Belt2").GetComponent<ConveyorBelt> ().sped = 0;
						GameObject.Find ("Belt1").GetComponent<ConveyorBelt> ().enabled= true;
						GameObject.Find ("Belt2").GetComponent<ConveyorBelt> ().enabled= false;

					} else if (hit.transform.gameObject.name.Equals ("InactiveSourcePortal2")) {
						GameObject.Find ("Belt1").GetComponent<ConveyorBelt> ().sped = 0;
						GameObject.Find ("Belt2").GetComponent<ConveyorBelt> ().sped = sped;
						GameObject.Find ("Belt1").GetComponent<ConveyorBelt> ().enabled= false;
						GameObject.Find ("Belt2").GetComponent<ConveyorBelt> ().enabled= true;
					}
					copy = GameObject.Instantiate (GameObject.Find ("SourcePortal"));
					copy.transform.position = hit.transform.position;
					if(copy.GetComponent<teleport> ().Destination==null)
						copy.GetComponent<teleport> ().Destination=GameObject.Find ("DestinationPortal").transform;
				}	
				if (hit.transform.gameObject.CompareTag ("Portal")) {
					portaltutup.Play ();
					GameObject.Find ("Belt1").GetComponent<ConveyorBelt> ().sped = 0;
					GameObject.Find ("Belt2").GetComponent<ConveyorBelt> ().sped = 0;
					Destroy (GameObject.Find ("SourcePortal(Clone)"));
				}
				if (hit.transform.gameObject.CompareTag ("InactiveDestination")) {
					portalbuka.Play ();
					Destroy (GameObject.Find ("DestinationPortal(Clone)"));
					copy = GameObject.Instantiate (GameObject.Find ("DestinationPortal"));
					copy.transform.position = hit.transform.position;
					copy.transform.rotation = hit.transform.rotation;
					copy.transform.localScale = hit.transform.localScale;
				}
			}

		}
	}
}
