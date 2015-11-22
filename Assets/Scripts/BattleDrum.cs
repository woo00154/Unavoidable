using UnityEngine;
using System.Collections;

public class BattleDrum : MonoBehaviour {

    AudioSource audios;
    public AudioClip drumSound;

    private float default_tempo = 24.0f;
    private float min_tempo = 3.0f;
    private float tempo;
    private bool triggered = false;

    // Use this for initialization
    void Start () {
        audios = GetComponent<AudioSource>();
        tempo = 0.0f;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && !triggered)
        {
            audios.clip = drumSound;
            audios.loop = false;
            
            

            triggered = true;
            



        }
    }

    // Update is called once per frame
    void Update () {
	    if (triggered)
        {
            tempo -= 0.1f;
            if (tempo <= 0.0f)
            {
                audios.Play();
                default_tempo -= 1.0f;
                if (default_tempo <= min_tempo)
                    default_tempo = min_tempo;
                tempo = default_tempo;
                
            }
        }
	}
}
