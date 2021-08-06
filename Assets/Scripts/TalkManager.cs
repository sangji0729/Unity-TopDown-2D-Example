using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    void Start()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    
    void GenerateData()
    {
        /* Girl = 1000
         * Man = 2000
         * box = 200
         * desk = 100
         */
        talkData.Add(1000, new string[] { "한남 실좆 6.9cm 재기해라 이기:3",
                                            "한남소추:2" });
        talkData.Add(100, new string[] { "틀니 쉰내 내뿜지 말라이기야",
                                            "확 회쳐벌라 조용히 있다 나가라" });
        talkData.Add(200, new string[] { "농어랴~",
                                            "다희엄마 끓여줘야지 머" });
        talkData.Add(2000, new string[] { "저 놈저저 당체 무슨....:3",
                                            "수철이가 뭐 착각했나본데요 뭔 저런;;;:1" });


        //Quest Talk
        talkData.Add(10 + 1000, new string[] { "이 논비건은 뭐노 이기:3",
                                                "가서 한남유충이랑 말이나 섞으라 이기야:1",
                                                "Girls can do anything!:2"});

        talkData.Add(11 + 2000, new string[] { "다희 엄마가 독박육아를 하더니 정신이 나갔나봐...:0",
                                                "농어라도 잡아서 끓여줘야겠는데:1",
                                                "저기 물 옆에 농어좀 갖다줘:2"});

        //portrait Data

        //0 : noEmotion    1: talkFace    2: smileFace     3: angryFace
        portraitData.Add(1000 + 0, portraitArr[0]);
        portraitData.Add(1000 + 1, portraitArr[1]);
        portraitData.Add(1000 + 2, portraitArr[2]);
        portraitData.Add(1000 + 3, portraitArr[3]);

        portraitData.Add(2000 + 0, portraitArr[4]);
        portraitData.Add(2000 + 1, portraitArr[5]);
        portraitData.Add(2000 + 2, portraitArr[6]);
        portraitData.Add(2000 + 3, portraitArr[7]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if(talkIndex == talkData[id].Length)
        {
            return null;
        }
        else
        {
            return talkData[id][talkIndex];
        }
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex]; 
    }
}
