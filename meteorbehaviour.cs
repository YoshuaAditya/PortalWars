using UnityEngine;
using System.Collections;

public class meteorbehaviour : MonoBehaviour {

	private float speed;

	private Rigidbody2D rb;

//	[SerializeField]
	private float xrand, yrand;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		xrand = (Random.value * 20) - 7;
		yrand = (Random.value * 4) + 6;
		speed = 2f;
		rb.transform.position = new Vector3 (xrand, yrand);
	}

	void Update() //before rendering frame
	{

	}
	void FixedUpdate() //just before physics calculation
	{		
		rb.velocity = new Vector2 (-speed, -speed);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("collMeteor"))
		{
			xrand = (Random.value * 20) - 7;
			yrand = (Random.value * 4) + 6;
			rb.transform.position = new Vector3 (xrand, yrand);
		}
	}
}
