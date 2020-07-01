using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeSceneUIManager : MonoBehaviour
{

    int[] highScores;
    public Text[] LevelHighScores = new Text[10];
    // Start is called before the first frame update
    void Start()
    {
        highScores = DataController.Instance.GetHighScores();
        for (int i = 0; i < highScores.Length; i++)
        {
            LevelHighScores[i].text = "Best timing: " + highScores[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
