//
//  Created by Jason Walters
//  http://glitchbeam.com
//  http://twitter.com/jasonrwalters
//
//  Kinect Joint IDs http://glitchbeam.com/2015/04/02/kinect-v2-joint-map/
//
//----------------------------------------------

using UnityEngine;
using System.Collections;
using Kinect = Windows.Kinect;

public class BodyParticles : MonoBehaviour
{
    public GameObject joints;
    public bool bodyDetected = false;

    private GameObject[] clone = new GameObject[25];

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < BodySourceView.jointObjs.Length; i++)
        {
            if (BodySourceView.bodyTracked)
            {
                Vector3 pos = BodySourceView.jointObjs[i].localPosition;
                Quaternion rot = BodySourceView.jointObjs[i].localRotation;

                if (clone[i] == null)
                {
                    clone[i] = Instantiate(joints, pos, rot) as GameObject;
                    // parent to this gameobject
                    clone[i].transform.parent = transform;
                }
                else
                {
                    clone[i].transform.localPosition = pos;
                    clone[i].transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);

                    ParticleSystem pars = clone[i].GetComponentInChildren<ParticleSystem>();
                    pars.Play();
                }
            }
            else
            {
                if (clone[i] != null)
                {
                    ParticleSystem pars = clone[i].GetComponentInChildren<ParticleSystem>();
                    pars.Stop();
                }
            }
        }
	}
}
