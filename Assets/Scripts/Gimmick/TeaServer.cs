using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaServer : MonoBehaviour
{
  // クリックされた時、たぬきがいれば動けない
  // たぬきがいなければ消える

  public Tanuki tanuki;

  private void Start()
  {
    bool clearGimmick = SaveManager.instance.GetGimmickFlag(SaveManager.Flag.MovedTeaServer);
    if (clearGimmick)
    {
      Move();
    }
  }

  public void OnThis()
  {
    bool movedTanuki = tanuki.isMoved;
    if (movedTanuki)
    {
      SaveManager.instance.SetGimmickFlag(SaveManager.Flag.MovedTeaServer);
      Move();
    }
    else
    {
      Debug.Log("たぬきがいて動かせない");
    }
  }

  void Move()
  {
    gameObject.SetActive(false);
  }
}
