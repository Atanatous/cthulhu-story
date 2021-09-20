using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{

    public GameObject pannel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Collide!");
        StartCoroutine(LoadSceneAfterTranstion());
    }

    private IEnumerator LoadSceneAfterTranstion() {
        Animator animator = pannel.GetComponent<Animator>();
        animator.SetBool("animateOut", true);

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("BattleScene");
    }
}
