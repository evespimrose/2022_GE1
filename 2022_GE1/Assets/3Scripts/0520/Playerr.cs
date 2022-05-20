using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerr : MonoBehaviour
{
    public Data data;
    public void setPlayerData(Data d)
    {
        data = d;
        transform.position = d.playerPosition;
        transform.rotation = Quaternion.Euler(d.playerRotation);
    }
    private void Update()
    {
        data.playerPosition = transform.position;
        data.playerRotation = transform.rotation.eulerAngles;
    }
}
