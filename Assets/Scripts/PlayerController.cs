using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody body;

    [SerializeField]
    float spinSpeed = 0.2f;
    
    [SerializeField]
    Vector3 forceForward;
    [SerializeField]
    Vector3 forceSideways;

    [SerializeField]
    KeyCode keyForward;
    [SerializeField]
    KeyCode keyBackward;
    [SerializeField]
    KeyCode keyRight;
    [SerializeField]
    KeyCode keyLeft;

    void Start() {
        body = GetComponent<Rigidbody>();
    }

    void Update() {
        body.transform.rotation = new Quaternion(body.transform.rotation.x, body.transform.rotation.y + spinSpeed * Time.deltaTime, body.transform.rotation.z);
        
        if (Input.GetKey(keyForward)) body.velocity += forceForward;
        if (Input.GetKey(keyBackward)) body.velocity -= forceForward;
        if (Input.GetKey(keyRight)) body.velocity += forceSideways;
        if (Input.GetKey(keyLeft)) body.velocity -= forceSideways;
    }
}
