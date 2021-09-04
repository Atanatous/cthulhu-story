using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect : MonoBehaviour
{
  // Start is called before the first frame update
  private Text textComponent;
  private string subText = "";
  private string originText = "";
  public bool isFinished = false;

  void Start()
  {
    textComponent = this.gameObject.GetComponent<Text>();
    originText = textComponent.text;
    StartCoroutine("TypingAction");
  }



  IEnumerator TypingAction()
  {
    for (int i = 0; i < originText.Length + 1; i++)
    {
      yield return new WaitForSeconds(0.1f);
      textComponent.text = originText.Substring(0, i);
    }

    isFinished = true;
  }
}
