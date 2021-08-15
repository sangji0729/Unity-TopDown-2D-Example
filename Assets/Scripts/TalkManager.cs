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
        talkData.Add(1000, new string[] { "안녕:1",
                                            "이 곳에 처음 왔구나?:2" });
        talkData.Add(100, new string[] { "누군가 사용한 흔적이 있는 책상이다."});
        talkData.Add(200, new string[] { "평범한 나무상자다." });
        talkData.Add(2000, new string[] { "여어.:1",
                                            "이 호수는 정말 아름답지?:0",
                                            "사실 이 호수에는 무언가의 비밀이 숨겨져 있다고 해:1"});


        //Quest Talk
        talkData.Add(10 + 1000, new string[] { "어서 와.:2",
                                                "이 마을에 놀라운 전설이 있다는데:1",
                                                "오른쪽 호수 쪽에 루도가 알려줄꺼야:2"});

        talkData.Add(11 + 2000, new string[] { "여어.:2",
                                                "이 호수의 전설을 들으러 온거야?:1",
                                                "그럼 일 좀 하나 해주면 좋을텐데..:0",
                                                "내 집 근처에 떨어진 동전 좀 주워줬으면 해.:2"});

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
