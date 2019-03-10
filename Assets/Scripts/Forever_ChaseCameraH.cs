using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっとカメラがこのオブジェクトを追いかける（水平のみ）
public class Forever_ChaseCameraH : MonoBehaviour {

    Vector3 base_pos;

    void Start() { // 最初に行う
        // カメラの元の位置を覚えておく
        base_pos = Camera.main.gameObject.transform.position;
    }

    void LateUpdate() { // ずっと行う（色々な処理の最後に）
        Vector3 pos = this.transform.position; // 自分の位置
        pos.z = -10;                           // カメラなので手前に移動させる
        Camera.main.gameObject.transform.position = pos;
    }
}
