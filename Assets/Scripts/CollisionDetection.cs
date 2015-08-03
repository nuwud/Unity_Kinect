using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour
{
    private Renderer rend;

	// Use this for initialization
	void Start ()
    {
        // reference components
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT ENTER");
        rend.material.color = new Color(0.0f, 1.0f, 0.0f);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("HIT EXIT");
        rend.material.color = new Color(1.0f, 0.0f, 0.0f);
    }
}
