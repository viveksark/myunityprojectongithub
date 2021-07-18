using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 public class Myfirstscript : MonoBehaviour
{
    public Button button;
    public string newscene;
    public GameObject exitpanel;
    private void Start()
    {
        button.onClick.AddListener(OnButtonclick);
    }

    private void OnButtonclick()
    {
        Debug.Log("button clicked");
        SceneManager.LoadScene(newscene);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                if (exitpanel)
                {
                    exitpanel.SetActive(true);

                }
            }
    
        } 
    }
}

