using UnityEngine;
using System.Collections;


public class Main_Menu_new : MonoBehaviour 
{
	TextMesh playMesh;
	public bool isQuit = false;

	// Use this for initialization
	void Start () {
		playMesh = GetComponent<TextMesh>();



	
	}

	void OnMouseEnter()
	{
		playMesh.color= Color.red;

	}

	void OnMouseExit()
	{
		playMesh.color=Color.white;

	}

	void OnMouseDown()
	{
		if (isQuit) 
		{
			Application.Quit ();
		}
		else
		{
			Application.LoadLevel ("TestRoom");
            Cursor.visible = !Cursor.visible;
        }
	}
	// Update is called once per frame
	void Update() 
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{

			Application.Quit();
		}
			
	}
}
