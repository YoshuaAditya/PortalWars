using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update() //before rendering frame
	{

	}
	void FixedUpdate() //just before physics calculation
	{
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("Portal"))
		{
			speed = Mathf.Abs(speed);
		}
	}
}
