using UnityEngine;
using System.Collections;

public class BaseBehaviour2 : MonoBehaviour {
    public double health = 200;
    public string TagList = "|Monster||laser|"; // List of all tags that can teleport
                                         // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (GameObject.Find("Base").GetComponent<BaseBehaviour>().health <= 0) {
			Application.LoadLevel ("Lose");
		}
		else if (GameObject.Find("Base1").GetComponent<BaseBehaviour>().health <= 0) {
			Application.LoadLevel ("Win");
		}*/
    }
    public void OnTriggerEnter(Collider other)
    {
        // If the tag of the colliding object is allowed to teleport
        if (TagList.Contains(string.Format("|{0}|", other.tag)))
        {
            Destroy(other.gameObject);
            health -= 10;
        }
    }
}
