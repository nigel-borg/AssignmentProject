using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    // Start is called before the first frame update
    float destroyTime = 5;//does not effect time game starts
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, destroyTime);
    }
}
