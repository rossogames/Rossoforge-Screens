using Rossoforge.Core.UI.Screens;
using Rossoforge.Events.Bus;

namespace Rossoforge.UI.Screens.Events
{
    public readonly struct ScreenActivatedEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenActivatedEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
