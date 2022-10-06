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
        talkData.Add(1000, new string[] { "�ȳ�?", "�̰��� ó�� �Ա���?" });

        talkData.Add(100, new string[] { "����� �������ڴ�." });
        talkData.Add(100, new string[] { "������ ����ߴ� ������ �ִ� å���̴�." });
    }

    public string GetTalk(int id, int talkIndex)
    {
        return talkData[id][talkIndex];
    }
    //ž�ٿ� 2D RPG - ��ȭ �ý��� �����ϱ� [����Ƽ ���� ���� B23] 10:30
    //https://iagreebut.tistory.com/46
}
