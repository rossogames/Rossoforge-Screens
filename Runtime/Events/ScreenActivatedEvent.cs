using Rossoforge.Events.Bus;
using Rossoforge.Screens.UI;

namespace Rossoforge.Screens.Events
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
