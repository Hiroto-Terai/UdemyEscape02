using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
  public GameObject rightArrow;
  public GameObject leftArrow;
  public GameObject backArrow;
  enum Panel
  {
    Panel0,
    Panel1,
    Panel2,
    Panel3,
    Panel4,
    Panel5,
    Panel6,
    Panel7,
    Panel8,
  }
  // 列挙型のため、デフォルト値のPanel0が最初に入る
  Panel currentPanel;

  private void Start()
  {
    // currentPanelを設定(列挙型で自動的に入ってるけど一応記載)
    Show(Panel.Panel0);
  }

  void HideArrows()
  {
    rightArrow.SetActive(false);
    leftArrow.SetActive(false);
    backArrow.SetActive(false);
  }

  public void OnRightButton()
  {
    switch (currentPanel)
    {
      case Panel.Panel0:
        Show(Panel.Panel1);
        break;
      case Panel.Panel1:
        Show(Panel.Panel2);
        break;
      case Panel.Panel6:
        Show(Panel.Panel7);
        break;
      case Panel.Panel7:
        Show(Panel.Panel8);
        break;
    }
  }
  public void OnLeftButton()
  {
    switch (currentPanel)
    {
      case Panel.Panel1:
        Show(Panel.Panel0);
        break;
      case Panel.Panel2:
        Show(Panel.Panel1);
        break;
      case Panel.Panel7:
        Show(Panel.Panel6);
        break;
      case Panel.Panel8:
        Show(Panel.Panel7);
        break;
    }

  }
  public void OnBackButton()
  {
    switch (currentPanel)
    {
      case Panel.Panel3:
        Show(Panel.Panel0);
        break;
      case Panel.Panel4:
        Show(Panel.Panel1);
        break;
      case Panel.Panel5:
        Show(Panel.Panel2);
        break;
    }
  }

  public void OnLocker()
  {
    Show(Panel.Panel3);
  }

  public void OnPig()
  {
    Show(Panel.Panel4);

  }

  public void OnBucket()
  {
    Show(Panel.Panel5);
  }

  public void OnHoleIn()
  {
    Show(Panel.Panel6);
  }

  public void OnHoleOut()
  {
    Show(Panel.Panel2);
  }

  void Show(Panel panel)
  {
    HideArrows();
    currentPanel = panel;
    switch (panel)
    {
      case Panel.Panel0:
        rightArrow.SetActive(true);
        transform.localPosition = new Vector2(0, 0);
        break;
      case Panel.Panel1:
        rightArrow.SetActive(true);
        leftArrow.SetActive(true);
        transform.localPosition = new Vector2(-1000, 0);
        break;
      case Panel.Panel2:
        leftArrow.SetActive(true);
        transform.localPosition = new Vector2(-2000, 0);
        break;
      case Panel.Panel3:
        backArrow.SetActive(true);
        transform.localPosition = new Vector2(0, 1500);
        break;
      case Panel.Panel4:
        backArrow.SetActive(true);
        transform.localPosition = new Vector2(-1000, 1500);
        break;
      case Panel.Panel5:
        backArrow.SetActive(true);
        transform.localPosition = new Vector2(-2000, 1500);
        break;
      case Panel.Panel6:
        rightArrow.SetActive(true);
        transform.localPosition = new Vector2(0, 3000);
        break;
      case Panel.Panel7:
        rightArrow.SetActive(true);
        leftArrow.SetActive(true);
        transform.localPosition = new Vector2(-1000, 3000);
        break;
      case Panel.Panel8:
        leftArrow.SetActive(true);
        transform.localPosition = new Vector2(-2000, 3000);
        break;

    }
  }

}
