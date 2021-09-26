using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
  public GameObject mapPrefab;
  public int roomCount;

  // Start is called before the first frame update
  void Start()
  {

    int x = 0;
    int y = 0;
    for (int i = 0; i < roomCount; i++)
    {
      float rand = Random.Range(0, 1.0f);
      if (rand >= 0.5f)
      {
        x += 1;
      }
      else
      {
        y += 1;
      }
      Instantiate(mapPrefab, new Vector3(5.2f * x, 5.2f * y, 0), Quaternion.identity);
    }
  }




  // Update is called once per frame
  void Update()
  {

  }
}
