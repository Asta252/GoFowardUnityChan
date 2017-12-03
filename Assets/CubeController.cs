using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeController : MonoBehaviour {
    private float speed = -0.2f;
    private float deadline = -10;
    private AudioSource audioSource;
    public AudioClip audioClip;
	// Use this for initialization
	void Start () {
        audioSource =gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);
        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            audioSource.Play();
        }
    }
}
