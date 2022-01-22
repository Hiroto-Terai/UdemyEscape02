using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanuki : MonoBehaviour
{
  // クリックされた時に
  // Leafを持っていれば
  // 消える

  public bool isMoved = false;

  public void OnThis()
  {
    bool hsaLeaf = ItemBox.instance.CanUseItem(ItemManager.Item.Leaf); // TODO: アイテムBOXの実装、アイテムの実装
    if (hsaLeaf)
    {
      isMoved = true;
      gameObject.SetActive(false);
      ItemBox.instance.UseItem(ItemManager.Item.Leaf);
    }
  }
}
