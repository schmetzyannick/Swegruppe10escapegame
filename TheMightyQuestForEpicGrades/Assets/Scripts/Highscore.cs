using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;
using UnityEngine.SceneManagement;

public class Highscore : MonoBehaviour {

    public Text name { get; set; }
    public Text zeit { get; set; }
    public Text punkte { get; set; }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextWindowOnClick(int level)
    {
        Persist.save<Highscore>(this);
        SceneManager.LoadScene(level);
    }

}
