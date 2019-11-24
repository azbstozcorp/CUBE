using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody body;

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

        if (Input.GetKey(keyForward)) body.velocity += forceForward;
        if (Input.GetKey(keyBackward)) body.velocity -= forceForward;
        if (Input.GetKey(keyRight)) body.velocity += forceSideways;
        if (Input.GetKey(keyLeft)) body.velocity -= forceSideways;
    }
}
