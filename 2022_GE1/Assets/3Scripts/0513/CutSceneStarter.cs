using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutSceneStarter : MonoBehaviour
{
    public PlayableDirector pd;
    void Update()
    {
        if(Input.anyKeyDown)
        {
            pd.Play();
        }
    }
}
