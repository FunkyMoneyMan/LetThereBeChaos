using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextScene()
    {
        GetComponent<Animator>().SetTrigger("Next");
        Debug.Log("Test");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
