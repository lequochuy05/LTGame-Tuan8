using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;
    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;

    void Start()
    {
        GameMenu.enabled = false;
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want continue?";
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    public void NextScene()
    {
        // Tải scene tiếp theo bằng buildIndex hoặc bằng tên scene bạn có
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex); // Tạm thời tải lại hoặc chuyển index + 1
    }

    public void RestartScene()
    {
        // Tự động load lại chính scene đang chạy mà không sợ sai tên scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}