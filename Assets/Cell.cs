using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

    public bool mined;
    public bool investigated;

	// Use this for initialization
	void Start () {
        //if (mined == true)
        //    gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
        if (investigated == true)
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
	}
}
