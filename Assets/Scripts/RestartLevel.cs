using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
    [SerializeField]
    KeyCode keyRestartLevel;

    void Update() {
        if (Input.GetKey(keyRestartLevel)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
