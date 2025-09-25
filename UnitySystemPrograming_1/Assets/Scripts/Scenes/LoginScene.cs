using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Login;

        //List<GameObject> list = new List<GameObject>();
        //for (int i = 0; i < 10; i++)
        //{
        //    list.Add(Managers.Resource.Instantiate("Player"));
        //}

        //foreach (var go in list)
        //{
        //    Managers.Resource.Destroy(go);
        //}
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //SceneManager.LoadScene("Game");
            //SceneManager.LoadSceneAsync; // 비동기

            Managers.Scene.LoadScene(Define.Scene.Game); // 동기
        }
    }

    public override void Clear()
    {
        Debug.Log("씬 초기화 완료");
    }
}
