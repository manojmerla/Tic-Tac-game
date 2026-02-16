using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gridspace : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI buttonText;
    public string playerText;

    void Awake()
    {
        button = GetComponent<Button>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetSpace()
    {
        buttonText.text = playerText;
        button.interactable = false;
    }
}
