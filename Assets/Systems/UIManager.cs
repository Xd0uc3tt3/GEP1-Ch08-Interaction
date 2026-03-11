using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject interactionPrompt;
    [SerializeField] private TextMeshProUGUI messageText;

    public void ShowInteractionPrompt(bool show)
    {
        if (interactionPrompt != null)
        {
            interactionPrompt.SetActive(show);
        }
    }

    public void ShowMessage(string message)
    {
        StopAllCoroutines();
        StartCoroutine(DisplayMessage(message));
    }

    private IEnumerator DisplayMessage(string message)
    {
        messageText.gameObject.SetActive(true);
        messageText.text = message;

        yield return new WaitForSeconds(3f);

        messageText.gameObject.SetActive(false);
    }
}
