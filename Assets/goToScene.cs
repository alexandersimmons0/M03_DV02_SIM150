using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goToScene : MonoBehaviour
{
    public Button button;
    public string scene;
    void Start(){
        button.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick(){
        SceneManager.LoadScene(scene);
    }
}
