using UnityEngine;
using System.Collections;

public class CubeSEController : MonoBehaviour {

    private AudioSource SE;
    private bool BlockSETrigger = true;

	// Use this for initialization
	void Start () {
	   SE = GetComponent<AudioSource>();
	}

    void OnCollisionEnter2D(Collision2D other){
        if(BlockSETrigger){
            SE.PlayOneShot(SE.clip);
            BlockSETrigger = false;
        }

    }

}
