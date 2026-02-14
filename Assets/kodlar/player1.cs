using UnityEngine;

public class CubeArrow_Transform : MonoBehaviour
{
    public float speed = 5f;
    public bool isPlayer = false;

    void Update()
    {
        if (!isPlayer) return; // Oyuncu değilse çalışmasın

        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))  x = -1f; // Sol
        if (Input.GetKey(KeyCode.RightArrow)) x = 1f;  // Sağ
        if (Input.GetKey(KeyCode.UpArrow))    z = 1f;  // İleri
        if (Input.GetKey(KeyCode.DownArrow))  z = -1f; // Geri

        Vector3 move = new Vector3(x, 0, z);
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }
}