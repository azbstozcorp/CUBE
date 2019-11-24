using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject player;

    [SerializeField]
    private Vector3 desiredOffset;

    void LateUpdate() {
        transform.position = player.transform.position + desiredOffset;
    }
}
