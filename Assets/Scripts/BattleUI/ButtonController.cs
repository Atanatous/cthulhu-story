using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
  public Button attackButton;

  void Start()
  {
    attackButton.onClick.AddListener(Attack);
  }

  // Update is called once per frame
  void Update()
  {


  }

  void Attack()
  {
    GameObject player = GameObject.Find("Player");
    PlayerController playerController = player.GetComponent<PlayerController>();
    playerController.hp -= 10;

    if (playerController.hp <= 0)
    {
      player.SetActive(false);
    }
  }
}
