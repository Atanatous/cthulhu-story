using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{

  public Button fightButton, fleeButton;

  void Start()
  {
    fightButton.onClick.AddListener(fight);
    fleeButton.onClick.AddListener(flee);
  }

  public void fight()
  {
    Debug.Log("Fight");
  }

  public void flee()
  {
    Debug.Log("Run");
  }
}
