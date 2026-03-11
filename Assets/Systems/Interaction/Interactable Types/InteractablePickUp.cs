using UnityEngine;

public class InteractablePickUp : MonoBehaviour, IInteractable
{
    [SerializeField] private string pickupName = "Coin";
    [SerializeField] private string messageText = "You picked up a coin!";

    public void Interact()
    {
        ServiceHub.Instance.UIManager.ShowMessage(messageText);

        Debug.Log($"Picked up {pickupName}");
        Destroy(gameObject, 0.1f);
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
