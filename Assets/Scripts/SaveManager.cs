using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
  const string SAVE_KEY = "SaveData";
  public SaveData saveData;

  public static SaveManager instance;

  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
      Load();
    }
  }

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

  // Itemを取得したフラグ。アイテムBOXに追加される
  public void SetGetItemFlag(ItemManager.Item item)
  {
    int index = (int)item;
    saveData.getItems[index] = true;
    Save();
  }

  public bool GetGetItemFlag(ItemManager.Item item)
  {
    int index = (int)item;
    return saveData.getItems[index];
  }
}

[Serializable]
public class SaveData
{
  public bool[] getItems = new bool[(int)ItemManager.Item.Max];
  public bool[] useItems = new bool[(int)ItemManager.Item.Max];
}
