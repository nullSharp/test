﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    private bool canDie = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "an" && canDie && collision.gameObject.name != "pezzzo" && collision.gameObject.name != "pezzzo(1)" && collision.gameObject.name != "pezzzo(2)" && collision.gameObject.name != "pezzzo(3)" && collision.gameObject.name != "collider")
        {
            Debug.Log("я здох");
            if(canDie)
            {
                StartCoroutine(die());
            }
        }
    }
  IEnumerator die()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
