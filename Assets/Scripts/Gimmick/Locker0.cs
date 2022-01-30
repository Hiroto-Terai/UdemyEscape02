using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker0 : MonoBehaviour
{
  // ダイアルをクリアしたら、ロッカーをオープンにする: Openオブジェクトを表示
  public GameObject openObj;

  private void Start()
  {
    bool clearGimmick = SaveManager.instance.GetGimmickFlag(SaveManager.Flag.OpenedLocker01);
    if (clearGimmick)
    {
      Open();
    }
  }
  public void Open()
  {
    openObj.SetActive(true);
    SaveManager.instance.SetGimmickFlag(SaveManager.Flag.OpenedLocker01);
  }
}
