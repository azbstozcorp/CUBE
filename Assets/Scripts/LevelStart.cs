using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour {

    private void OnLevelWasLoaded(int level) {
        var player = GameObject.FindGameObjectWithTag("Player");
        var spawn = GameObject.FindGameObjectWithTag("Spawnpoint");

        player.transform.position = spawn.transform.position;
    }
}
