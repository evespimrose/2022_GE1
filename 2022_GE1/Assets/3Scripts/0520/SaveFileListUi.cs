using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using TMPro;

public class SaveFileListUi : MonoBehaviour
{
    public Playerr player;
    public Button loadButtonPrefab;

    private string saveFileFolderPath => Application.persistentDataPath;
    // Start is called before the first frame update
    void Start()
    {
        var fileList = Directory.GetFiles(saveFileFolderPath);

        foreach( var fileName in fileList)
        {
            var loadButton = Instantiate(loadButtonPrefab, transform);
            loadButton.GetComponentInChildren<TMP_Text>().text = saveFileFolderPath;
            loadButton.onClick.AddListener(() =>
            {
                var jsonStr = File.ReadAllText(Path.Combine(saveFileFolderPath, fileName));
                player.setPlayerData(JsonConvert.DeserializeObject<Data>(jsonStr));
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
