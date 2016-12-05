using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LoadScores : MonoBehaviour {

    public Text platz1 { get; set; }
    public Text platz2 { get; set; }
    public Text platz3 { get; set; }
    public Text platz4 { get; set; }
    public Text platz5 { get; set; }
    public Text platz6 { get; set; }
    public Text platz7 { get; set; }
    public Text platz8 { get; set; }
    public Text platz9 { get; set; }
    public Text platz10 { get; set; }

    // Use this for initialization
    void Start () {
        List<Highscore> scores = new List<Highscore>();
        for( int i=0;i<10;i++)
        {
            //wie funktioniert laden ?
            //scores.Add(Persist.load<Highscore>("highscore"));
        }
        platz1.text = scores[0].name.ToString() + scores[0].punkte.ToString() + scores[0].zeit.ToString();
        platz2.text = scores[1].name.ToString() + scores[1].punkte.ToString() + scores[1].zeit.ToString();
        platz3.text = scores[2].name.ToString() + scores[2].punkte.ToString() + scores[2].zeit.ToString();
        platz4.text = scores[3].name.ToString() + scores[3].punkte.ToString() + scores[3].zeit.ToString();
        platz5.text = scores[4].name.ToString() + scores[4].punkte.ToString() + scores[4].zeit.ToString();
        platz6.text = scores[5].name.ToString() + scores[5].punkte.ToString() + scores[5].zeit.ToString();
        platz7.text = scores[6].name.ToString() + scores[6].punkte.ToString() + scores[6].zeit.ToString();
        platz8.text = scores[7].name.ToString() + scores[7].punkte.ToString() + scores[7].zeit.ToString();
        platz9.text = scores[8].name.ToString() + scores[8].punkte.ToString() + scores[8].zeit.ToString();
        platz10.text = scores[9].name.ToString() + scores[9].punkte.ToString() + scores[9].zeit.ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
