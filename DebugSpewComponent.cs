using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.DebugSpew
{
    class DebugSpewComponent : IComponent
    {
        private LiveSplitState _state;
        public static DebugSpewWindow SpewWindow;
        void state_OnReset(object sender, TimerPhase t) { }

        public DebugSpewComponent(LiveSplitState state)
        {
            _state = state;
            _state.OnReset += state_OnReset;
            Settings = new DebugSpewSettings();
            SpewWindow = new DebugSpewWindow(state);
            SpewWindow.Show();

            Debug.Listeners.Add(TimedTraceListener.Instance);

            ContextMenuControls = new Dictionary<string, Action>();
            ContextMenuControls.Add("Open Debug View", () => SpewWindow.Show());

        }

        public string ComponentName => "Debug Spew Viewer";
        public DebugSpewSettings Settings { get; set; }
        public IDictionary<string, Action> ContextMenuControls { get; protected set; }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region region)
        {
            this.PrepareDraw(state);
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region region)
        {
            this.PrepareDraw(state);
        }

        void PrepareDraw(LiveSplitState state) { }

        public XmlNode GetSettings(XmlDocument document) { return document.CreateElement("Settings"); }
        public Control GetSettingsControl(LayoutMode mode) { return Settings; }
        public void SetSettings(XmlNode settings) { }
        public void RenameComparison(string oldName, string newName) { }
        public float MinimumWidth { get { return 0; } }
        public float MinimumHeight { get { return 0; } }
        public float VerticalHeight { get { return 0; } }
        public float HorizontalWidth { get { return 0; } }
        public float PaddingLeft { get { return 0; } }
        public float PaddingRight { get { return 0; } }
        public float PaddingTop { get { return 0; } }
        public float PaddingBottom { get { return 0; } }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }

        public void Dispose()
        {
            _state.OnReset -= state_OnReset;
            SpewWindow.Close();
            SpewWindow.Dispose();
            Settings.Dispose();
            Debug.Listeners.Remove(TimedTraceListener.Instance);
        }
    }
}
