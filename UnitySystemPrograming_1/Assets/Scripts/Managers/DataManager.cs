using System;
using System.Collections.Generic;
using UnityEngine;



public interface ILoader<Key, Value>
{
    Dictionary<Key, Value> MakeDict();
}

public class DataManager 
{
    // �����(API)
    // json -> ����
    // XML -> ����
    public Dictionary<int, Stat> StatDict { get; private set; } = new Dictionary<int, Stat>();
    //public Dictionary<string, Stat> MonstertDict { get; private set; } = new Dictionary<string, Stat>();

    public void Init()
    {
        StatDict = LoadJson<StatData, int, Stat>("StatData").MakeDict();
        //MonstertDict = LoadJson<MonsterData, int, Stat>("StatData").MakeDict();
    }

    Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>($"Data/StatData");
        return JsonUtility.FromJson<Loader>(textAsset.text);

    }
}
