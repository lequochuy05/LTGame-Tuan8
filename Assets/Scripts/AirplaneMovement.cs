using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    public float forwardSpeed = 10f; // Tốc độ bay thẳng tới trước
    public float turnSpeed = 50f;    // Tốc độ lượn/rẽ trái phải

    void Update()
    {
        // 1. Tự động bay về phía trước theo trục Z (hoặc bay khi bấm nút)
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // 2. Nhận phím điều hướng A/D hoặc Mũi tên Trái/Phải để rẽ
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);
    }
}