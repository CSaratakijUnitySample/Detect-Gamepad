using UnityEngine;

public class GamepadWatcher : MonoBehaviour
{
    [SerializeField]
    bool isCheckLessFrequent = true;

    static GamepadWatcher instance = null;
    public static bool IsConnect { get; private set; }

    string[] gamepadNames;


    void Awake()
    {
        MakeSingleton();
    }

    void Start()
    {
        CheckGamepad();
    }

    void Update()
    {
        DetectGamepadHandler();
    }

    void MakeSingleton()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    void DetectGamepadHandler()
    {
        if (isCheckLessFrequent) {
            if (Input.anyKey) {
                CheckGamepad();
            }
        }
        else {
            CheckGamepad();
        }
    }

    void CheckGamepad()
    {
        gamepadNames = Input.GetJoystickNames();

        foreach (string name in gamepadNames) {
            if (string.IsNullOrEmpty(name)) {
                continue;
            }
            else {
                IsConnect = true;
                return;
            }
        }

        IsConnect = false;
        return;
    }
}
