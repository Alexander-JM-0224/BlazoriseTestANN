using Microsoft.AspNetCore.Components;

namespace BlazoriseTestApp.Components
{
    public class PageHeaderState
    {
        public event Action? OnChange;

        private string? _title;
        public string? Title
        {
            get => _title;
            set
            {
                _title = value;
                NotifyStateChanged();
            }
        }

        private RenderFragment? _actions;
        public RenderFragment? Actions
        {
            get => _actions;
            set
            {
                _actions = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
