using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
  // 鍵をクリックした時に、鍵を持っていればOpenにする
  // 持っていなければログを出す
  public GameObject openObj;

  public void OnThis()
  {
    bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key);
    if (hasKey)
    {
      // Openにする
      Open();
    }
    else
    {
      Debug.Log("鍵がかかっている");
    }
  }

  void Open()
  {
    // 開いている画像を表示
    openObj.SetActive(true);
    ItemBox.instance.UseItem(ItemManager.Item.Key);
  }
}
