using UnityEngine;

public class Define
{
    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount // ���� �̳��� ��� �մ� ������ ����
    }

    public enum Scene
    {
        Unknown,
        Login,
        Lobby,
        Game,

    }

    public enum MouseEvent
    {
        Press,
        Click,
    }

    public enum CameraMode
    {
        QuarterView,
    }

    public enum UIEvent
    {
        Click,
        Drag
    }
}
