using System.IO;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private void Start()
    {
        SaveGame(10,20);
        LoadGame();
    }
    private void SaveGame(int viewers, int money)
    {
        PlayerData playerData = new PlayerData();
        playerData.Viewers = viewers;
        playerData.Money = money;
        
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.dataPath + "/saveFile.json", json);
    } 
    private void LoadGame()
    {
        string json = File.ReadAllText(Application.dataPath + "/saveFile.json");
        PlayerData loadData = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log(loadData.Money);
        Debug.Log(loadData.Viewers);
    }

    class PlayerData
    {
        public int Viewers;
        public int Money;
    }
}
