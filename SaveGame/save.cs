using System.IO;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private void Start()
    {
        PlayerData playerData = new PlayerData();
        playerData.Viewers = 80;
        playerData.Money = 100;
        
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.dataPath + "/saveFile.json", json);
    }
    class PlayerData
    {
        public int Viewers;
        public int Money;
    }
}
