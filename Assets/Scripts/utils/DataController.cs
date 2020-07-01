using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DataController : Singleton<DataController>
{
    PlayerProgress playerProgress;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        LoadPlayerProgress();
        SceneManager.LoadScene("new_main");
    }

    public void SubmitNewPlayerScore(int newScore, int level)
    {
        if (newScore > playerProgress.highScores[level-1])
        {
            playerProgress.highScores[level-1] = newScore;
            SavePlayerProgress(level);
        }
    }

    public int[] GetHighScores()
    {
        return playerProgress.highScores;
    }

    void LoadPlayerProgress()
    {
        playerProgress = new PlayerProgress();
        if (PlayerPrefs.HasKey("H1"))
        {
            playerProgress.highScores[0] = PlayerPrefs.GetInt("H1");
        }

        if (PlayerPrefs.HasKey("H2"))
        {
            playerProgress.highScores[1] = PlayerPrefs.GetInt("H2");
        }

        if (PlayerPrefs.HasKey("H3"))
        {
            playerProgress.highScores[2] = PlayerPrefs.GetInt("H3");
        }

        if (PlayerPrefs.HasKey("H4"))
        {
            playerProgress.highScores[3] = PlayerPrefs.GetInt("H4");
        }

        if (PlayerPrefs.HasKey("H5"))
        {
            playerProgress.highScores[4] = PlayerPrefs.GetInt("H5");
        }

        if (PlayerPrefs.HasKey("H6"))
        {
            playerProgress.highScores[5] = PlayerPrefs.GetInt("H6");
        }

        if (PlayerPrefs.HasKey("H7"))
        {
            playerProgress.highScores[6] = PlayerPrefs.GetInt("H7");
        }

        if (PlayerPrefs.HasKey("H8"))
        {
            playerProgress.highScores[7] = PlayerPrefs.GetInt("H8");
        }

        if (PlayerPrefs.HasKey("H9"))
        {
            playerProgress.highScores[8] = PlayerPrefs.GetInt("H9");
        }

        if (PlayerPrefs.HasKey("H10"))
        {
            playerProgress.highScores[9] = PlayerPrefs.GetInt("H10");
        }
    }


    private void SavePlayerProgress(int lvl)
    {
        // Save the value playerProgress.highestScore to PlayerPrefs, with a key of "highestScore"
        string key = "H" + lvl;
        PlayerPrefs.SetInt(key, playerProgress.highScores[lvl-1]);
    }

}
