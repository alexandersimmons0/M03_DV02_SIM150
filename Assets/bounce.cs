using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    private Rigidbody _rb;
    private float thrust;
    private float min = 1000;
    private float max = 10000;
    void Start(){
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate(){
        thrust = Random.Range(min, max);
    }
    void OnCollisionEnter(Collision body){
        if(body.collider.tag=="ground"){
            _rb.AddForce(transform.forward * thrust);
        }
    }
}
