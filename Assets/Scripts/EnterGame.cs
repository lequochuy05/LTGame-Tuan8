using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra xem chính đối tượng hoặc đối tượng cha của nó có Tag là "Player" hay không
        if (other.CompareTag("Player") || (other.transform.root != null && other.transform.root.CompareTag("Player")))
        {
            Debug.Log("Đã va chạm với Wall!"); // In log để kiểm tra
            if (GameMenu != null)
            {
                GameMenu.enabled = true; // Bật Popup Menu
            }
        }
    }
}