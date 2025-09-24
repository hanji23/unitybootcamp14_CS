// Logger를 사용하는이유
// 1. 타임스탬프 (추가적인 정보 로깅)
// 2. 출시용 빌드에서 로깅 코드를 일괄적으로 제거
using System.Diagnostics;

public static class Logger 
{
    [Conditional("DEV_VER")] // 유니티 프로젝트세팅 플레이어 -> 스크립팅 디파인 심볼에서 추가, 삭제
    public static void Log(string msg)
    {
        UnityEngine.Debug.LogFormat("{0} {1}", System.DateTime.Now.ToString("yyyy_MM_dd HH:mm:ss.fff"), msg);
    }
    [Conditional("DEV_VER")]
    public static void LogWarning(string msg)
    {
        UnityEngine.Debug.LogWarningFormat("{0} {1}", System.DateTime.Now.ToString("yyyy_MM_dd HH:mm:ss.fff"), msg);
    }

    public static void LogError(string msg)
    {
        UnityEngine.Debug.LogErrorFormat("{0} {1}", System.DateTime.Now.ToString("yyyy_MM_dd HH:mm:ss.fff"), msg);
    }
}
