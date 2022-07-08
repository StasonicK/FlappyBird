
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClicked; 
    
    protected override void OnButtonClick()
    {
        RestartButtonClicked?.Invoke();
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }
}
