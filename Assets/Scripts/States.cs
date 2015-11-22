using UnityEngine;
using System.Collections;

public class States : MonoBehaviour {



    private string[] states; 
    public string current_state;


    // Use this for initialization
    void Start () {
	    states= new string[3] { "start", "game", "end" };
        current_state = states[0];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
