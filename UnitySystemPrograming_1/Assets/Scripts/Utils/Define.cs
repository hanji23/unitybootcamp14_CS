using UnityEngine;

public class Define
{
    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount // 현재 이넘이 들고 잇는 갯수를 말함
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
