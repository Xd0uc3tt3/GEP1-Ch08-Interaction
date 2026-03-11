using UnityEngine;

public class InteractableSign : MonoBehaviour, IInteractable
{
    [SerializeField] private string pickupName = "Sign";
    [SerializeField] private string messageText = "You read the sign";

    public void Interact()
    {
        ServiceHub.Instance.UIManager.ShowMessage(messageText);

        Debug.Log($"Read sign");
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
