using Rossoforge.Events.Bus;
using Rossoforge.Screens.UI;

namespace Rossoforge.Screens.Events
{
    public readonly struct ScreenOpeningEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenOpeningEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
