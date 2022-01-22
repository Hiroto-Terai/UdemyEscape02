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
  }

  private void Start()
  {
    SetItem(ItemManager.Item.Leaf);
  }

  public void SetItem(ItemManager.Item item)
  {
    int index = (int)item;
    boxes[index].SetActive(true);
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
  }
}
