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
  }
  public Item item;

  // クリックされた時に消す、アイテムBOXに追加する
  public void OnThis()
  {
    gameObject.SetActive(false);
    ItemBox.instance.SetItem(item);
  }
}
