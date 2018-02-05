using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Scripts.GSF.FrameWork
{
    public class ModuleEvent : UnityEvent<object>
    {
    }

    public class ModuleEvent<T> : UnityEvent<T>
    {
    }

    public class EventTable
    {
        private Dictionary<string, ModuleEvent> m_mapEvents;
        public ModuleEvent GetEvent(string type)
        {
            if (m_mapEvents == null)
            {
                m_mapEvents = new Dictionary<string, ModuleEvent>();
            }
            if (!m_mapEvents.ContainsKey(type))
            {
                m_mapEvents.Add(type, new ModuleEvent());
            }
            return m_mapEvents[type];
        }

        public void Clear()
        {
            if (m_mapEvents != null)
            {
                foreach (var @event in m_mapEvents)
                {
                    @event.Value.RemoveAllListeners();
                }
                m_mapEvents.Clear();
            }
        }
    }
}

