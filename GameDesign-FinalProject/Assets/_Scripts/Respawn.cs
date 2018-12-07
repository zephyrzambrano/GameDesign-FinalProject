using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public float minHeightForDeath;
    public Vector3 spawnPoint=new Vector3(0, 1, 0);
    public GameObject player;

    void Update() {
        if (player.transform.position.y < minHeightForDeath) {
            player.transform.position = spawnPoint;
        }
    }
}
