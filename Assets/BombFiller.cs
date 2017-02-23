using UnityEngine;
using System.Collections;

public class BombFiller : MonoBehaviour {

    public bool bombInCell;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("collide");
        if (coll.gameObject.GetComponent<Cell>() != null)
        {
            if (coll.gameObject.GetComponent<Cell>().mined == true)
                bombInCell = true;

            if (coll.gameObject.GetComponent<Cell>().mined == false)
                bombInCell = false;
        }
        else
        {
            bombInCell = false;
        }
    }
}
