using UnityEngine;
using System.Collections;

public class lookBehind : MonoBehaviour {

    AudioSource audios;
    public AudioClip scareSound;
    

    // Use this for initialization
    void Start () {
        audios = GetComponent<AudioSource>();
    }
	
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            audios.clip = scareSound;
            audios.loop = false;
            audios.Play();

            
            
            
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
