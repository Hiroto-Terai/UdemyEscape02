using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaServer : MonoBehaviour
{
  // クリックされた時、たぬきがいれば動けない
  // たぬきがいなければ消える

  public Tanuki tanuki;

  public void OnThis()
  {
    bool movedTanuki = tanuki.isMoved;
    if (movedTanuki)
    {
      gameObject.SetActive(false);
    }
    else
    {
      Debug.Log("たぬきがいて動かせない");
    }
  }
}
