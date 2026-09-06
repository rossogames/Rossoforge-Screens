using Rossoforge.Scenes.Service;
using Rossoforge.Screens.UI;
using Rossoforge.Services.Locator;

namespace Rossoforge.Screens.Samples.ScreenTemplate
{
    public class ScreenTemplatePresenter : ScreenPresenter<ScreenTemplateView, ScreenTemplatePresenter>
    {
        private readonly ISceneService _sceneService;

        public ScreenTemplatePresenter(ScreenTemplateView view) : base(view)
        {
            _sceneService = ServiceLocator.Get<ISceneService>();
        }

        public override void OnOpening()
        {
            base.OnOpening();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Opening");
        }

        public override void OnActivate()
        {
            base.OnActivate();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Activated");
        }

        public override void OnClosing()
        {
            base.OnClosing();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Closing");
        }

        public override void OnDeactivate()
        {
            base.OnDeactivate();
            UnityEngine.Debug.LogWarning("ScreenTemplatePresenter Deactivated");
        }

        public void PlayGame()
        {
            _sceneService.RestartScene();
        }
    }
}