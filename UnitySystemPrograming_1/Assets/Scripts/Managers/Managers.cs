using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_Instance; // 유일성이 보장됨
    public static Managers Instance {  get { Init(); return s_Instance; } }

    private InputManager _input = new InputManager();
    public static InputManager Input { get { return Instance._input; } }

    private ResouceManager _resouce = new ResouceManager();
    public static ResouceManager Resource { get { return Instance._resouce; } }

    private UIManager _ui = new UIManager();
    public static UIManager UI {  get { return Instance._ui; } }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_Instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_Instance = go.GetComponent<Managers>();
        }
    }
}
