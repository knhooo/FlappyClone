using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {   
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(2,Random.Range(-2.61f,4.72f),0);
            timer = 0;
            Destroy(newpipe,10.0f);
        }
        
    }
}
