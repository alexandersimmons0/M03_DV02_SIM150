using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFall : MonoBehaviour
{
    private float speed = 20f;
    private float time;
    void Start()
    {
        this.transform.position = new Vector3(8f,40f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.timeSinceLevelLoad;
        this.transform.position = this.transform.position - this.transform.up * (time/speed);
        if(this.transform.position.y<-24f){
            this.transform.position = new Vector3(8f,40f,0f);
        }
    }
}
