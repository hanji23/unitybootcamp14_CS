using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{

    public Animation LogoAnim;
    public TextMeshProUGUI LogoText;

    public GameObject Title;

    public Slider _loadingSlider;
    public TextMeshProUGUI _loadingProgressText;

    private AsyncOperation _asyncOperation;

    private void Awake()
    {
        LogoAnim.gameObject.SetActive(true);
        Title.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(LoadGameCoroutine());
    }

    private IEnumerator LoadGameCoroutine()
    {
        Logger.Log($"{GetType()} :: LoadGameCoroutine");

        LogoAnim.Play();
        yield return new WaitForSeconds(LogoAnim.clip.length);

        LogoAnim.gameObject.SetActive(false);
        Title.SetActive(true);

        _asyncOperation = SceneLoader.Instance.LoadSceneAsync(SceneType.Lobby);

        if (_asyncOperation == null)
        {
            Logger.Log($"로딩 에러");
            yield break;
        }

        _asyncOperation.allowSceneActivation = false; // 씬이동을 자동으로 하는 것을 막기 위한 코드

        //_loadingSlider.value = 0.5f;
        _loadingProgressText.text = ((int)(_loadingSlider.value * 100)).ToString();
        yield return new WaitForSeconds(0.5f);

        while (_asyncOperation.isDone == false)
        {
            _loadingSlider.value = _asyncOperation.progress < 0.5f ? 0.5f : _asyncOperation.progress;
            _loadingProgressText.text = ((int)(_loadingSlider.value * 100)).ToString();

            if(_asyncOperation.progress >= 0.9f)
            {
                _asyncOperation.allowSceneActivation = true;
                yield break;
            }
            yield return null;
        }
    }
}
