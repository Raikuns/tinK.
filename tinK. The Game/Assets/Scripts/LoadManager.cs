using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadManager : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public TMP_Text progressText;

    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync (int sceneIndex)
    {
        AsyncOperation Operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!Operation.isDone)
        {
            float progress = Mathf.Clamp01(Operation.progress / .9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;

        }
    }
}
