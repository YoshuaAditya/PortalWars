using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerupHealth : MonoBehaviour {


	//	private Vector3 offset1,offset2;
	private bool aktif=false;
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
		if (counter == 1500) {
			aktif = true;
			activate.Play ();
		}
		if (!aktif) {
			counter+=1;
			bar.fillAmount = (1500f-counter) / 1500f;
		}
		if ( Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit=Physics2D.Raycast (ray.origin,ray.direction);
			click.Play ();
			if (hit&&aktif) {
				if (hit.transform.gameObject.name.Equals("health")) {
					GameObject.Find ("Base").GetComponent<BaseBehaviour>().Health += 30;
					counter = 0;
					aktif = false;
					click.Play ();
				}		
			}
		}
	}
}
