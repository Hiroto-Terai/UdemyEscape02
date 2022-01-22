using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialLocker : MonoBehaviour
{
  // 3つのボタンをそれぞれクリックして絵柄が全て一致すればクリア

  // ボタンの画像を取得
  public Image[] buttons;
  // 表示するマークを列挙
  public enum Mark
  {
    Maru,
    Sankaku,
    Hoshi,
    Daia
  }

  // 現在のマーク
  Mark[] currentMarks = { Mark.Maru, Mark.Maru, Mark.Maru };

  Mark[] correctMarks = { Mark.Maru, Mark.Sankaku, Mark.Hoshi };

  // 表示する画像の素材一覧
  public Sprite[] resourceSprite;

  public UnityEvent ClearEvent;

  public void OnMarkButton(int position)
  {
    // positionのマークを変更する
    ChangeMark(position);
    // positionの画像を表示する
    ShowMark(position);

    if (IsAllClearMark())
    {
      Clear();
    }
  }

  void ChangeMark(int position)
  {
    currentMarks[position]++; // 1つ次のマーク
    if (currentMarks[position] > Mark.Daia)
    {
      currentMarks[position] = Mark.Maru;
    }
  }

  void ShowMark(int position)
  {
    int index = (int)currentMarks[position]; // int化
    buttons[position].sprite = resourceSprite[index];  // 対応する画像を表示
  }

  bool IsAllClearMark()
  {
    for (int i = 0; i < currentMarks.Length; i++)
    {
      if (currentMarks[i] != correctMarks[i])
      {
        // 1つでも違うものがあればクリアではない
        return false;
      }
    }
    return true;
  }

  void Clear()
  {
    Debug.Log("ロッカーが開いた");
    ClearEvent.Invoke();
  }
}
