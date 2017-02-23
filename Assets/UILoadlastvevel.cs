using UnityEngine;
using System.Collections;

public class UILoadlastvevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Loadlastlevel()
    {
        Application.LoadLevel(PlayerPrefs.GetString("LastLevel"));
    }
}
