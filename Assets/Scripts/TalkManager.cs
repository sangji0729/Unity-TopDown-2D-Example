using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    void Start()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    
    void GenerateData()
    {
        talkData.Add(1000, new string[] { "한남 실좆 6.9cm 재기해", "한남소추" });
        talkData.Add(100, new string[] { "틀니 쉰내 내뿜지 말라이기야" });
        talkData.Add(200, new string[] { "저 놈저저 당체 무슨...." });
    }

    public string GetTalk(int id, int talkIndex)
    {
        return talkData[id][talkIndex];
    }
}
