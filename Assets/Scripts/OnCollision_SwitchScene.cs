using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン切り替えに必要

// 衝突するとシーンを切り替える
public class OnCollision_SwitchScene : MonoBehaviour {

    public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
    public string sceneName;        // シーン名：Inspectorで指定
    
    // 衝突した時
    void OnCollisionEnter2D(Collision2D collision) {
        // もし衝突したものの名前が目標オブジェクトだったら
        if (collision.gameObject.name == targetObjectName) {
            // シーンを切り替える
            SceneManager.LoadScene (sceneName);
        }        
    }
}
