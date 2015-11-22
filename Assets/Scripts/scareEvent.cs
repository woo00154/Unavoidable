using UnityEngine;
using System.Collections;

public class scareEvent : MonoBehaviour {

	AudioSource audios;
    public Camera cam1;
    public Camera cam2;

	public Texture2D noiseTexture;
	public Texture2D scareTexture;
    public AudioSource drumAudio;
	public AudioClip scareSound;
	public float scareTime = 3f;
	public Renderer rend;

    private bool triggered = false;
    private float anotherTimer = 3f;

	void Start()
	{
		audios = GetComponent<AudioSource> ();
		rend = GetComponent<Renderer>();

	}
	

	
	bool showScare = false;

	void OnTriggerEnter(Collider other)
	
	{

        if (other.gameObject.tag == ("Player"))
        {
            triggered = true;
            drumAudio.enabled = false;

        }
	}


    // Update is called once per frame
    void Update()
    {

        if (triggered)
        {
            
            scareTime -= Time.fixedDeltaTime;
            if (scareTime <= 0)
            {
                cam1.enabled = false;
                cam2.enabled = true;
                
                audios.clip = scareSound;
                audios.loop = false;
                
                audios.Play();
                
                
                triggered = false;


            }
        }
        
        if (!triggered && scareTime <= 0)
        {
            anotherTimer -= Time.fixedDeltaTime;
            if (anotherTimer <= 0)
            {
                Application.LoadLevel("MainMenu");
                Cursor.visible = !Cursor.visible;
            }
                

        }
	}
}
