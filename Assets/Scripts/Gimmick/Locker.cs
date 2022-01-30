using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
  // クリックした時に、鍵を持っていれば Openにする
  // 持っていなければログを出す
  public GameObject openObj;

  private void Start()
  {
    // すでにクリアしているなら
    bool clearGimmick = SaveManager.instance.GetGimmickFlag(SaveManager.Flag.OpenedLocker);
    if (clearGimmick)
    {
      Open();
    }
  }

  public void OnThis()
  {
    bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key);
    if (hasKey)
    {
      SaveManager.instance.SetGimmickFlag(SaveManager.Flag.OpenedLocker);
      Open();
      ItemBox.instance.UseItem(ItemManager.Item.Key);
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
  }
}
