using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public BombFiller[] bombFillers;
    public GameObject mainShip;

    public float startcoinsCount;

    public int bombCount;

    public bool death;

    public float maxYPos;
    public float minYPos;
    public float maxXPos;
    public float minXPos;

    public Text bombsAround;
    public Text coinsCount;

    public string nextlevelName;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetString("LastLevel",Application.loadedLevelName);
        PlayerPrefs.SetString("NextLevel", nextlevelName);
	}
	
	// Update is called once per frame
	void Update () {

        startcoinsCount -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxYPos)
            gameObject.transform.position += new Vector3(0,1,0);
        if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minYPos)
            gameObject.transform.position -= new Vector3(0, 1, 0);

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < maxXPos)
            gameObject.transform.position += new Vector3(1, 0, 0);
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > minXPos)
            gameObject.transform.position -= new Vector3(1, 0, 0);

        bombCount = 0;
        for (int i = 0; i < bombFillers.Length; i++)
        {
            if (bombFillers[i].bombInCell == true)
                bombCount++;
        }
        bombsAround.text = "Бомб вокруг: " + bombCount.ToString();
        coinsCount.text = ((int)startcoinsCount).ToString();
        PlayerPrefs.SetInt("CurrentScore", (int)startcoinsCount);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Cell>() != null)
        {
            if (coll.gameObject.GetComponent<Cell>().mined == true)
                death = true;
        }
    }
}
