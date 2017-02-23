using UnityEngine;
using System.Collections;

public class UILoadNextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadNextLevel()
    {
        Application.LoadLevel(PlayerPrefs.GetString("NextLevel"));
    }
}
