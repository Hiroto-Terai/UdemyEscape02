using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanuki : MonoBehaviour
{
  // クリックされた時に
  // Leafを持っていれば
  // 消える

  public bool isMoved = false;

  private void Start()
  {
    bool clearGimmick = SaveManager.instance.GetGimmickFlag(SaveManager.Flag.MovedTanuki);
    if (clearGimmick)
    {
      Move();
    }
  }

  public void OnThis()
  {
    bool hasLeaf = ItemBox.instance.CanUseItem(ItemManager.Item.Leaf);
    if (hasLeaf)
    {
      Move();
      ItemBox.instance.UseItem(ItemManager.Item.Leaf);
    }
  }

  void Move()
  {
    isMoved = true;
    SaveManager.instance.SetGimmickFlag(SaveManager.Flag.MovedTanuki);
    gameObject.SetActive(false);
  }
}
