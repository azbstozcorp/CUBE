using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour {
    [SerializeField]
    string nextScene;

    public static bool change;

    void Update() {
        if (change) SceneManager.LoadScene(nextScene);
    }
}
