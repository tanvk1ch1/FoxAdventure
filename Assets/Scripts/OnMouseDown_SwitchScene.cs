using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// タッチしたらシーンを切り替える
public class OnMouseDown_SwitchScene : MonoBehaviour {

    public string sceneName; // シーン名：Inspectorで指定

    // タッチしたら
    void OnMouseDown() {
        // シーンを切り替える
        SceneManager.LoadScene (sceneName);        
    }
}
