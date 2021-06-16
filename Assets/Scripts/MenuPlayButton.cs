using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuPlayButton : MonoBehaviour
{
    public Text TxtBestScore;
    private void Awake()
    {
        if (PlayerPrefs.HasKey("BestScore"))
        {
            TxtBestScore.text = "BEST SCORE: " + PlayerPrefs.GetInt("BestScore").ToString();
        }
    }
    public void PressPlayBtn()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
