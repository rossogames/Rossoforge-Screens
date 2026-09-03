using Rossoforge.Core.UI.Screens;
using Rossoforge.Events.Bus;

namespace Rossoforge.UI.Screens.Events
{
    public readonly struct ScreenDeactivatedEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenDeactivatedEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
