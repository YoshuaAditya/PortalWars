using UnityEngine;
using System.Collections;

public class ClickPosition : MonoBehaviour {

	private Vector3 toScreenPoint;
	public float xWorld=20;
	public float xLanes=4;
	public float yWorld=10;
	public float yLanes=4;
	private string clicked;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetMouseButtonDown(0)){
			if (clicked == null) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				if (Physics.Raycast (ray, out hit, 100)) {
					if(!hit.transform.gameObject.CompareTag("Base"))
					clicked = hit.transform.gameObject.name;
				}
			} else {
				toScreenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				toScreenPoint.z = 0;
				GameObject.Find(clicked).transform.position = toScreenPoint;
				clicked = null;
			}
		}
	}
		
}
/*#if UNITY_EDITOR
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//for touch device
#elif (UNITY_ANDROID || UNITY_IPHONE || UNITY_WP8)
ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
#endif


if (Input.GetMouseButtonDown (0)) {		
		newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = newPosition;	
}
			
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			newPosition = hit.point;
			transform.position = newPosition;	
		}

 private var screenPoint: Vector3;
     private var offset: Vector3;
     private var curScreenPoint : Vector3;
     private var curPosition : Vector3;
     
     function Start () {
     }
     
     function Update () {
     }
     
     function OnMouseDown () {
         screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
         offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
         Screen.showCursor = false;
         }
     
     function OnMouseDrag() { 
         curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
         curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
         transform.position = curPosition;
         }
     
     function OnMouseUp(){
         Screen.showCursor = true;
         }


     var defaultMaterial : Material;
     var onHoverMaterial : Material;
     
     function OnMouseEnter(){
         defaultMaterial = renderer.material;
         renderer.material = onHoverMaterial;
     }
     
     function OnMouseExit(){
         renderer.material = defaultMaterial ;
     }
*/