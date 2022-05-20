using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class SaveButtonUi : MonoBehaviour
{
    public Playerr player;
    public string saveFileName = "save_file";
    private string saveFileFolderPath = Application.persistentDataPath;

    public void SaveNewFile()
    {
        var jsonstr = JsonConvert.SerializeObject(player.data);
        File.WriteAllText(Path.Combine(saveFileFolderPath, saveFileName), jsonstr);
    }
}
