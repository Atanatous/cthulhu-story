using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugUIController : MonoBehaviour
{
  public GameObject statusUI;

  private GameObject player;
  private PlayerController playerController;
  private Text statusText;

  void Start()
  {
    player = GameObject.Find("Player");
    playerController = player.GetComponent<PlayerController>();

    statusText = statusUI.GetComponent<Text>();
    statusText.text = "Player HP: " + playerController.hp;
    Debug.Log("Player HP: " + playerController.hp);
  }

  // Update is called once per frame
  void Update()
  {
    statusText.text = "Player HP: " + playerController.hp;
    if (playerController.hp <= 0)
    {
      statusText.text = "Player died";
    }
  }
}
