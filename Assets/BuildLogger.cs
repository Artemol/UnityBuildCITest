using UnityEngine;

public class BuildLogger : MonoBehaviour
{
  [SerializeField] private TMPro.TextMeshProUGUI text;
  void Awake()
  {

    text.SetText($"Unity Version: {Application.unityVersion}\nScripting Backend: {GetScriptingBackend()}");
    // Debug.Log($"Unity Version: {Application.unityVersion}");
    // Debug.Log($"Scripting Backend: {GetScriptingBackend()}");
  }

  static string GetScriptingBackend()
  {
#if ENABLE_MONO
    return "Mono";
#elif ENABLE_IL2CPP
    return "IL2CPP";
#else
    return "Unknown";
#endif
  }
}
