using UnityEngine;
using UnityEngine.UI;

public class UIGamepadWatcher : MonoBehaviour
{
    [SerializeField]
    Text lblStatus;


    void LateUpdate()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        lblStatus.text = (GamepadWatcher.IsConnect) ? "[ Connected ]" : "[ Disconnected ]";
    }
}
