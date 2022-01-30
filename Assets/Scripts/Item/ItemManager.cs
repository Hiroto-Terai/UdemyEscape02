using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
  public enum Item
  {
    Leaf,
    Key,
    Card,
    Hammer,
    HintCard,
    Max,
  }
  public Item item;

  private void Start()
  {
    // すでに取得しているなら表示しない
    bool hasItem = SaveManager.instance.GetGetItemFlag(item);
    bool usedItem = SaveManager.instance.GetUseItemFlag(item);
    if (usedItem)
    {
      gameObject.SetActive(false);
    }
    else if (hasItem)
    {
      SetToItemBox();
    }
  }

  // クリックされた時に消す、アイテムBOXに追加する
  public void OnThis()
  {
    SetToItemBox();
  }

  void SetToItemBox()
  {
    gameObject.SetActive(false);
    ItemBox.instance.SetItem(item);
  }
}
