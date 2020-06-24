using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

   public GameObject introScreen;
   public GameObject chooseSizeScreen;
   public GameObject chooseDifficulty;
  

   public void intoChooseSize(int index) {
        switch (index)
        {
            case 1:
                PlayerSettings.ScrambleRotationTime = 0.5f;
                PlayerSettings.ScrambleTimes = 4;
                break;
            case 2:
                PlayerSettings.ScrambleRotationTime = 0.35f;
                PlayerSettings.ScrambleTimes = 7;
                break;
            case 3:
                PlayerSettings.ScrambleRotationTime = 0.25f;
                PlayerSettings.ScrambleTimes = 10;
                break;
            case 4:
                PlayerSettings.ScrambleRotationTime = 0.15f;
                PlayerSettings.ScrambleTimes = 13;
                break;
            case 5:
                PlayerSettings.ScrambleRotationTime = 0.1f;
                PlayerSettings.ScrambleTimes = 16;
                break;
            case 6:
                PlayerSettings.ScrambleRotationTime = 0.08f;
                PlayerSettings.ScrambleTimes = 19;
                break;
            case 7:
                PlayerSettings.ScrambleRotationTime = 0.07f;
                PlayerSettings.ScrambleTimes = 22;
                break;
            case 8:
                PlayerSettings.ScrambleRotationTime = 0.06f;
                PlayerSettings.ScrambleTimes = 25;
                break;
            case 9:
                PlayerSettings.ScrambleRotationTime = 0.05f;
                PlayerSettings.ScrambleTimes = 28;
                break;
            case 10:
                PlayerSettings.ScrambleRotationTime = 0.04f;
                PlayerSettings.ScrambleTimes = 30;
                break;
            default:
                PlayerSettings.ScrambleRotationTime = 0.5f;
                PlayerSettings.ScrambleTimes = 8;
                break;

        }
      chooseDifficulty.SetActive(false);
      chooseSizeScreen.SetActive(true);
   }

    public void intoChooseDifficulty()
    {
        introScreen.SetActive(false);
        chooseDifficulty.SetActive(true);
    }

    public void LoadCube2(int index) {
      PlayerSettings.CubeSize = 2;
      SceneManager.LoadScene(index);
   }
   public void LoadCube3(int index) {
      PlayerSettings.CubeSize = 3;
      SceneManager.LoadScene(index);
   }
   public void LoadCube4(int index) {
      PlayerSettings.CubeSize = 4;
      SceneManager.LoadScene(index);
   }

   public void QuitGame() {
      StopAllCoroutines();
      Application.Quit();
   }
}
