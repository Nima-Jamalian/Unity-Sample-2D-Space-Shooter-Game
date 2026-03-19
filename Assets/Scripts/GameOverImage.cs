using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOverImage : MonoBehaviour
{
    private float delayTime = 0.4f;
    private Image image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(Animate());
    }

    private IEnumerator Animate()
    {
        while (true)
        {
            image.enabled = false;
            yield return new WaitForSeconds(delayTime);

            image.enabled = true;
            yield return new WaitForSeconds(delayTime);
        }
    }
}
