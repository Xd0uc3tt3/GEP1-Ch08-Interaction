using UnityEngine;

public class Message : MonoBehaviour, IInteractable
{
    [SerializeField] private string messageText = "Default message";

    public void Interact()
    {
        ServiceHub.Instance.UIManager.ShowMessage(messageText);
    }

    public void OnFocus()
    {
        ServiceHub.Instance.UIManager.ShowInteractionPrompt(true);
    }

    public void OnUnfocus()
    {
        ServiceHub.Instance.UIManager.ShowInteractionPrompt(false);
    }
}