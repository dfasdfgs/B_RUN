using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Buri;
    public float TimeDiff;

    float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newBuri = Instantiate(Buri);
            newBuri.transform.position = new Vector3(2.97f, Random.Range(6.53f, 3.02f), 0);
            timer = 0;

            Destroy(newBuri, 10.0f);
        }
    }
}
