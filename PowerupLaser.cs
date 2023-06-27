using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerupLaser : MonoBehaviour {
	private GameObject copy;
//	private Vector3 offset1,offset2;
    private bool pilihPortal=false,aktif=false;
//	[SerializeField]
    private float counter = 0;
	public AudioSource click, activate;
	public Image bar;
    // Use this for initialization
    void Start () {
//		offset1= new Vector3(-10,4.25f,1.5f);
//		offset2= new Vector3(-10,2.25f,1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (counter == 500) {
			aktif = true;
//			activate.Play ();
		}
		if (!aktif) {
			counter+=1;
			bar.fillAmount = (500f-counter) / 500f;
		}
		if ( Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit=Physics2D.Raycast (ray.origin,ray.direction);
			click.Play ();
			if (hit&&aktif) {
				if (hit.transform.gameObject.name.Equals("laser")&&!pilihPortal) {
                    pilihPortal = true;
					click.Play ();
                }

				else if ((hit.transform.gameObject.CompareTag("InactiveDestination")||(hit.transform.gameObject.CompareTag("Destination")))&&pilihPortal)
                {
					click.Play ();
                    pilihPortal = false;
                    copy = GameObject.Instantiate(GameObject.Find("sinar"));
                    copy.transform.position = hit.transform.gameObject.transform.position;
                    copy.GetComponent<Movement>().speed = 5;
                    counter = 0;
                    aktif = false; 
                }			
			}
		}
    }
}
