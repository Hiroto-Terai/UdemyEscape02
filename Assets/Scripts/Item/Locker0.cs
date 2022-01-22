using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker0 : MonoBehaviour
{
  // ダイアルをクリアしたら、ロッカーをオープンにする: Openオブジェクトを表示
  public GameObject openObj;
  public void Open()
  {
    openObj.SetActive(true);
  }
}
