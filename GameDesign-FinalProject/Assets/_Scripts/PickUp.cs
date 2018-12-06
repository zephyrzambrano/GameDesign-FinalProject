﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {

    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update() {
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