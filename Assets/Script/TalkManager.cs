using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        talkData.Add(1000, new string[] { "안녕?", "이곳에 처음 왔구나?" });

        talkData.Add(100, new string[] { "평범한 나무상자다." });
        talkData.Add(100, new string[] { "누군가 사용했던 흔적이 있는 책상이다." });
    }

    public string GetTalk(int id, int talkIndex)
    {
        return talkData[id][talkIndex];
    }
    //탑다운 2D RPG - 대화 시스템 구현하기 [유니티 기초 강좌 B23] 10:30
    //https://iagreebut.tistory.com/46
}
