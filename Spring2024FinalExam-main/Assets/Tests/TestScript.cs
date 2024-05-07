using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestScript
{


    [UnityTest]
    public IEnumerator PlayButtonStartsPlay()
    {
        SceneManager.LoadScene("Intro");
        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("PlayButton");
        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Game", SceneManager.GetActiveScene().name, "Game did not start after clicking PlayButton.");
    }

    [UnityTest]
    public IEnumerator StopButtonStopsPlay()
    {
        SceneManager.LoadScene("Intro");
        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("PlayButton");
        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        GameObject stopButton = GameObject.Find("StopButton");
        stopButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Exit", SceneManager.GetActiveScene().name, "Game did not start after clicking PlayButton.");
    }

    [UnityTest]
    public IEnumerator PlayAgainButtonRestartsGame()
    {
        SceneManager.LoadScene("Intro");
        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("PlayButton");
        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        GameObject stopButton = GameObject.Find("StopButton");
        stopButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        GameObject playAgainButton = GameObject.Find("PlayAgainButton");
        playAgainButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Intro", SceneManager.GetActiveScene().name, "Game did not start after clicking PlayButton.");
    }

    [UnityTest]
    public IEnumerator PlayerNameShownInGame()
    {
        yield return null;


    }

    [UnityTest]
    public IEnumerator DestroyingFiveTargetsStopsPlay()
    {
        yield return null;

    }

    [UnityTest]
    public IEnumerator NameFromIntroShowsInGameScene()
    {
        yield return null;
    }

}
