using UnityEngine;
using System.Collections;

public class ObjectDestroy : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        Destroy(this.gameObject, 4.0f);
	}
}
