using UnityEngine;
using System.Collections;

public class level4 : MonoBehaviour {

    public Vector3 Offset;
    private MeshRenderer mesh;
    private GameObject copy;
    private double y;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Time.frameCount

        if (Time.frameCount % 100 == 0)
        {
            y = Random.value;
            if (y < 0.34)
            {
                copy = GameObject.Instantiate(GameObject.Find("RedMonsterE"));
            }
            else if (y < 0.67)
            {
                copy = GameObject.Instantiate(GameObject.Find("BlueMonsterE"));
            }
            else
            {
                copy = GameObject.Instantiate(GameObject.Find("GreenMonsterE"));
            }


            y = Random.value;
            if (y < 0.34)
            {
                Offset.x = 5;
                Offset.y = -0.8f;
            }
            else if (y < 0.67)
            {
                Offset.x = 5;
                Offset.y = -2.6f;
            }
            else
            {
                Offset.x = 5;
                Offset.y = -4.3f;
            }


            copy.transform.position = Offset;
            copy.GetComponent<Movement>().speed = -2.5f;
            //mesh = copy.GetComponent<MeshRenderer>();
            //mesh.enabled = !mesh.enabled;
        }
    }
}