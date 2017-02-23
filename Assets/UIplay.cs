using UnityEngine;
using System.Collections;

public class UIplay : MonoBehaviour {

    public string levelname;

	public void PlayGame()
    {
        Application.LoadLevel(levelname);
    }
}
