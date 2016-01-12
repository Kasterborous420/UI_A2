using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
    public void Start()
    {
	
	}
	
	// Update is called once per frame
    public void Update()
    {
	}

    public void switchToGameScene()
    {
        Application.LoadLevel("GamePlay");
    }
    public void switchToSettingsScene()
    {
        Application.LoadLevel("SettingsScene");
    }
    public void switchToStoreScene()
    {
        Application.LoadLevel("StoreScene");
    }
    public void switchToCreditScene()
    {
        Application.LoadLevel("CreditScene");
    }
    public void switchToLeaderBoardScene()
    {
        Application.LoadLevel("LeaderBoard");
    }
    public void switchToStatsScene()
    {
        Application.LoadLevel("StatsScene");
    }
}
