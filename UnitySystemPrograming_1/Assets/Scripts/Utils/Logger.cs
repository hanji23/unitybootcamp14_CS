// Logger�� ����ϴ�����
// 1. Ÿ�ӽ����� (�߰����� ���� �α�)
// 2. ��ÿ� ���忡�� �α� �ڵ带 �ϰ������� ����
using System.Diagnostics;

public static class Logger 
{
    [Conditional("DEV_VER")] // ����Ƽ ������Ʈ���� �÷��̾� -> ��ũ���� ������ �ɺ����� �߰�, ����
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
