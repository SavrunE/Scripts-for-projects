using System.IO;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private void Start()
    {
        LoadGame();
    }
    private void SaveGame()
    {
        PlayerData playerData = new PlayerData();
        playerData.Viewers = 80;
        playerData.Money = 100;
        
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.dataPath + "/saveFile.json", json);
    } 
    private void LoadGame()
    {
        string json = File.ReadAllText(Application.dataPath + "/saveFile.json");
        PlayerData loadData = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log(loadData.Money);
    }

    class PlayerData
    {
        public int Viewers;
        public int Money;
    }
}
