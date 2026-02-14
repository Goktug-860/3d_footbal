using UnityEngine;

public class CubeWASD_Transform : MonoBehaviour
{
    public float speed = 5f;
    public bool isPlayer = false;

    void Update()
    {
        if (!isPlayer) return; // Oyuncu değilse çalışmasın

        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.A)) x = -1f;
        if (Input.GetKey(KeyCode.D)) x = 1f;
        if (Input.GetKey(KeyCode.W)) z = 1f;
        if (Input.GetKey(KeyCode.S)) z = -1f;

        Vector3 move = new Vector3(x, 0, z);
        //transform.position = New Vector3(x,transform.position.y,z);
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }
}