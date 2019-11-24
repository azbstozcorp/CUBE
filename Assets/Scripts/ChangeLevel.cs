using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour {
    [SerializeField]
    string nextScene;

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Attempting to load " + nextScene);
        SceneManager.LoadScene(nextScene);
    }
}
