using Rossoforge.Controls.Buttons;
using Rossoforge.Screens.UI;

namespace Rossoforge.Screens.Samples.ScreenTemplate
{
    public class ScreenTemplateView : ScreenView<ScreenTemplateView, ScreenTemplatePresenter>,
        IButtonClickListener<ScreenTemplateButtonPlay>
    {
        protected override void Awake()
        {
            base.Awake();
            Presenter = new ScreenTemplatePresenter(this);
        }

        public void OnClick(ButtonEventArg<ScreenTemplateButtonPlay> eventArg)
        {
            UnityEngine.Debug.LogWarning("Play button clicked!");
            Presenter.PlayGame();
        }
    }
}