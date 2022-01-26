using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
  const string SAVE_KEY = "SaveData";
  SaveData saveData;

  void Save()
  {
    string json = JsonUtility.ToJson(saveData);
    PlayerPrefs.SetString(SAVE_KEY, json);
  }

  void Load()
  {
    saveData = new SaveData();
    if (PlayerPrefs.HasKey(SAVE_KEY))
    {
      string json = PlayerPrefs.GetString(SAVE_KEY);
      saveData = JsonUtility.FromJson<SaveData>(json);
    }
  }
}

[Serializable]
public class SaveData
{
  public bool[] getItems = new bool[(int)ItemManager.Item.Max];
  public bool[] useItems = new bool[(int)ItemManager.Item.Max];
}
