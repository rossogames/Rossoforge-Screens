using Rossoforge.Events.Bus;
using Rossoforge.Screens.UI;

namespace Rossoforge.Screens.Events
{
    public readonly struct ScreenClosingEvent : IEvent
    {
        public readonly IScreenView ScreenView;

        public ScreenClosingEvent(IScreenView screenView)
        {
            ScreenView = screenView;
        }
    }
}
