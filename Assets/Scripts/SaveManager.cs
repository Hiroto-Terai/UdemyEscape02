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

  // ギミックフラグ列挙
  public enum Flag
  {
    OpenedLocker01,
    MovedTanuki,
    MovedTeaServer,
    OpenedLocker,
    BrokenPig,
    OpenedFireHydrant,
    OpenedElavor,
    Max,
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

  public void SetUseItemFlag(ItemManager.Item item)
  {
    int index = (int)item;
    saveData.useItems[index] = true;
    Save();
  }

  public bool GetUseItemFlag(ItemManager.Item item)
  {
    int index = (int)item;
    return saveData.useItems[index];
  }

  public void SetGimmickFlag(Flag flag)
  {
    int index = (int)flag;
    saveData.gimmick[index] = true;
    Save();
  }

  public bool GetGimmickFlag(Flag flag)
  {
    int index = (int)flag;
    return saveData.gimmick[index];

  }
}

[Serializable]
public class SaveData
{
  public bool[] getItems = new bool[(int)ItemManager.Item.Max];
  public bool[] useItems = new bool[(int)ItemManager.Item.Max];
  public bool[] gimmick = new bool[(int)SaveManager.Flag.Max];
}
