using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIGlobalScore : MonoBehaviour {

    public Text globalScore;

	// Use this for initialization
	void Start () {
        globalScore.text = PlayerPrefs.GetInt("GlobalScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
