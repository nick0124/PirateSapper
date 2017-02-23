using UnityEngine;
using System.Collections;

public class MainShip : MonoBehaviour {

    public bool death;
    public bool win;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Cell>() != null)
        {
            if (coll.gameObject.GetComponent<Cell>().mined == true)
            {
                Application.LoadLevel("lose");//death = true;
                PlayerPrefs.SetInt("GlobalScore", PlayerPrefs.GetInt("GlobalScore") + PlayerPrefs.GetInt("CurrentScore"));
            }

            if (coll.gameObject.GetComponent<Cell>().mined == false)
                death = false;

            coll.gameObject.GetComponent<Cell>().investigated = true;
        }
        else
        {
            death = false;
        }

        if (coll.gameObject.name == "Iland")
            Application.LoadLevel("win");//win = true;
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Cell>() != null)
        {
            coll.gameObject.GetComponent<Cell>().investigated = true;
        }
    }
}
