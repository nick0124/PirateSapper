using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIGold : MonoBehaviour {

    public Text gold;

	// Use this for initialization
	void Start () {
        gold.text = PlayerPrefs.GetInt("CurrentScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
