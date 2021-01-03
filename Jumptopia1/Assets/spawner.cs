using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime = 1;
private float timer = 0;
public GameObject pipe;
public float height;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(Random.Range(-height,height) ,0,0);
            timer = 0;
        }
    timer += Time.deltaTime;
    }
}
