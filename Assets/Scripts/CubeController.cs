using UnityEngine;

public class ShakeMovement : MonoBehaviour
{
    public float speed = 5f;   // 揺れる速さ
    public float range = 0.5f; // 揺れる幅

    private Vector3 startPos;

    void Start()
    {
        // 初期位置を保存
        startPos = transform.position;
    }

    void Update()
    {
        // Mathf.Sinで-1～1の値を取得し、左右に加算
        float x = Mathf.Sin(Time.time * speed) * range;
        transform.position = startPos + new Vector3(x, 0, 0);
    }
}

