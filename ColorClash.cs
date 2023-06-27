using UnityEngine;
using System.Collections;

public class ColorClash : MonoBehaviour {
    //private GameObject red2;
    private GameObject copy;
	private Vector3 Offset;
	public AudioSource colorClashAudio, MonsterDie;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
	void OnCollisionEnter2D(Collision2D collision) {
		if (this.name.Equals("RedMonsterP(Clone)") || this.name.Equals("RedMonsterPLv2(Clone)")) {
			if (collision.gameObject.name == "RedMonsterE(Clone)" || collision.gameObject.name == "RedMonsterELv2(Clone)")
            {
                Destroy(this.gameObject);
                copy = GameObject.Instantiate(GameObject.Find("RedMonsterELv2"));
				Offset = this.transform.position;
				Offset.x += 1.0f;
				Offset.y -= 0.23f;
				copy.transform.position = Offset;
				copy.GetComponent<Movement>().speed = collision.gameObject.GetComponent<Movement>().speed;
                Destroy(collision.gameObject);
				colorClashAudio.Play ();
            }
			else if (collision.gameObject.name=="GreenMonsterE(Clone)" || collision.gameObject.name == "GreenMonsterELv2(Clone)") {
				Destroy (collision.gameObject);
				MonsterDie.Play ();
			}
			else if (collision.gameObject.name=="BlueMonsterE(Clone)" || collision.gameObject.name == "BlueMonsterELv2(Clone)") {
				Destroy (this.gameObject);
				MonsterDie.Play ();
			}
		}
		else if (this.name.Equals("GreenMonsterP(Clone)") || this.name.Equals("GreenMonsterPLv2(Clone)")) {
			if (collision.gameObject.name == "RedMonsterE(Clone)" || collision.gameObject.name == "RedMonsterELv2(Clone)") {
				Destroy (this.gameObject);
				MonsterDie.Play ();
			}
			else if (collision.gameObject.name=="GreenMonsterE(Clone)" || collision.gameObject.name == "GreenMonsterELv2(Clone)") {
                Destroy(this.gameObject);
                copy = GameObject.Instantiate(GameObject.Find("GreenMonsterELv2"));
				Offset = this.transform.position;
				Offset.x += 1.0f;
				Offset.y -= 0.56f;
				copy.transform.position = Offset;
				copy.GetComponent<Movement>().speed = collision.gameObject.GetComponent<Movement>().speed;
                Destroy(collision.gameObject);
				colorClashAudio.Play ();
            }
            else if (collision.gameObject.name == "BlueMonsterE(Clone)" || collision.gameObject.name == "BlueMonsterELv2(Clone)")
            {
				Destroy (collision.gameObject);
				MonsterDie.Play ();
			}
		}
		else if (this.name.Equals("BlueMonsterP(Clone)") || this.name.Equals("BlueMonsterPLv2(Clone)")) {
			if (collision.gameObject.name=="RedMonsterE(Clone)" || collision.gameObject.name == "RedMonsterELv2(Clone)") {
				Destroy (collision.gameObject);
				MonsterDie.Play ();
			}
			else if (collision.gameObject.name=="GreenMonsterE(Clone)" || collision.gameObject.name == "GreenMonsterELv2(Clone)") {
				Destroy (this.gameObject);
				MonsterDie.Play ();
			}
			else if (collision.gameObject.name=="BlueMonsterE(Clone)" || collision.gameObject.name == "BlueMonsterELv2(Clone)") {
                Destroy(this.gameObject);
                copy = GameObject.Instantiate(GameObject.Find("BlueMonsterELv2"));
				Offset = this.transform.position;
				Offset.x += 1.0f;
				Offset.y += 0.1f;
				copy.transform.position = Offset;
				copy.GetComponent<Movement>().speed = collision.gameObject.GetComponent<Movement>().speed;
                Destroy(collision.gameObject);
				colorClashAudio.Play ();
            }
		}

	}
}
