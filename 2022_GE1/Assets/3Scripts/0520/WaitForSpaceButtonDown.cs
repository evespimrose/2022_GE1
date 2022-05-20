using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSpaceButtonDown : MonoBehaviour
{
    private bool _isSpaceButtonDown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSpaceButton());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _isSpaceButtonDown = true;
        }
    }
    private IEnumerator WaitForSpaceButton()
    {
        print("스페이스 버튼을 누르세요");
        yield return new WaitUntil(() => _isSpaceButtonDown);
        print("집에보내줘");
    }
}
