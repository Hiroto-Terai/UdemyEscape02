using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakblePig : MonoBehaviour
{
  // クリックした時に、ハンマーを持っていればOpenにする
  // 持っていなければログを出す
  public GameObject pigObj;
  public GameObject brokenPigObj;

  private void Start()
  {
    bool clearGimmick = SaveManager.instance.GetGimmickFlag(SaveManager.Flag.BrokenPig);
    if (clearGimmick)
    {
      Break();
    }
  }


  public void OnThis()
  {
    bool hasHammer = ItemBox.instance.CanUseItem(ItemManager.Item.Hammer);
    if (hasHammer)
    {
      SaveManager.instance.SetGimmickFlag(SaveManager.Flag.BrokenPig);
      Break();
      ItemBox.instance.UseItem(ItemManager.Item.Hammer);
    }
    else
    {
      Debug.Log("壊せそうだ");
    }
  }

  void Break()
  {
    // 普通のブタを非表示
    pigObj.SetActive(false);
    // 壊れたブタ画像を表示
    brokenPigObj.SetActive(true);
  }
}
