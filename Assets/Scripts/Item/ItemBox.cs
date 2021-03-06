using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
  public GameObject[] boxes;

  public static ItemBox instance;

  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
    }

    // 最初に全てのアイテムを非表示
    for (int i = 0; i < boxes.Length; i++)
    {
      boxes[i].SetActive(false);
    }
    // セーブデータがあると表示
  }

  // private void Start()
  // {
  //   // 最初に全てのアイテムを非表示
  //   for (int i = 0; i < boxes.Length; i++)
  //   {
  //     boxes[i].SetActive(false);
  //   }
  //   // セーブデータがあると表示
  // }

  public void SetItem(ItemManager.Item item)
  {
    int index = (int)item;
    boxes[index].SetActive(true);
    SaveManager.instance.SetGetItemFlag(item);
  }

  public bool CanUseItem(ItemManager.Item item)
  {
    int index = (int)item;
    if (boxes[index].activeSelf)
    {
      return true;
    }
    return false;
  }

  public void UseItem(ItemManager.Item item)
  {
    int index = (int)item;
    boxes[index].SetActive(false);
    SaveManager.instance.SetUseItemFlag(item);
  }
}
