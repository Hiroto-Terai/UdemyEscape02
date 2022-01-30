using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
  public GameObject leftObj;
  public GameObject rightObj;

  private void Start()
  {
    bool clearGimmick = SaveManager.instance.GetGimmickFlag(SaveManager.Flag.OpenedElavor);
    if (clearGimmick)
    {
      Open();
    }
  }



  public void OnThis()
  {
    bool hasCard = ItemBox.instance.CanUseItem(ItemManager.Item.Card);
    if (hasCard)
    {
      SaveManager.instance.SetGimmickFlag(SaveManager.Flag.OpenedElavor);
      Open();
      ItemBox.instance.UseItem(ItemManager.Item.Card);
    }
  }

  void Open()
  {
    // 左右の扉を消す
    leftObj.SetActive(false);
    rightObj.SetActive(false);
  }
}
