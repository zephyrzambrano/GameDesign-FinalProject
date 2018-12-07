using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Text countText;
    public Text winText;

    public float minHeightForDeath;
    public Vector3 spawnPoint = new Vector3(0, 1, 0);
    public GameObject player;

    // private Rigidbody rb;
    private int count;

    // Use this for initialization
    void Start() {
        // rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update() {
        if (player.transform.position.y < minHeightForDeath) {
            player.transform.position = spawnPoint;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText() {
        countText.text = "Points: " + count.ToString();
        if (count >= 10) {
            winText.text = "You Win!";
        }
    }

}