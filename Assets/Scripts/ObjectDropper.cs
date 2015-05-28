using UnityEngine;
using System.Collections;

public class ObjectDropper : MonoBehaviour
{
    public GameObject[] objects;
    public float fireRate;
    public float spawnWidth;

    private Transform tr;
    private float seconds;

    void Start()
    {
        // get local components
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // instantiates our objects
        Spawn(fireRate);
    }

    void Spawn(float rate)
    {
        // timer, adds up the delta time for seconds
        seconds += Time.deltaTime;
        // if seconds great than our rate as defined in the inspector
        if (seconds > rate)
        {
            // random x position
            float randomX = Random.Range(-spawnWidth, spawnWidth);
            Vector3 position = new Vector3
                (
                tr.position.x + randomX,
                tr.position.y,
                tr.position.z
                );

            // randomly select an object in the danger array
            int randomObj = Random.Range(0, objects.Length);
            Instantiate(objects[randomObj], position, transform.rotation);

            // zero out the seconds variable
            seconds = 0;
        }
    }
}