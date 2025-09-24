using UnityEngine;

public class TestSound : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public AudioClip audioClip;
    public AudioClip audioClip2;

    int i = 0;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource audio = GetComponent<AudioSource>();
        //audio.PlayClipAtPoint(월드좌표); // 특정 위치 소리 발생 시키기

        //audio.PlayOneShot(audioClip);
        //audio.PlayOneShot(audioClip2);

        //float lifeTime =  Mathf.Max(audioClip.length, audioClip2.length);
        //GameObject.Destroy(gameObject, lifeTime);

        //Managers.Sound.Play("Unity chan/univ0001");
        //Managers.Sound.Play("Unity chan/univ0002");

        i++;

        if(i % 2 == 0)

        Managers.Sound.Play("Unity chan/univ0001", Define.Sound.Bgm);
        else
        Managers.Sound.Play("Unity chan/univ0002", Define.Sound.Bgm);
    }
}
