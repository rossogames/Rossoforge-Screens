using Rossoforge.Events.Bus;
using Rossoforge.Screens.UI;

namespace Rossoforge.Screens.Events
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
