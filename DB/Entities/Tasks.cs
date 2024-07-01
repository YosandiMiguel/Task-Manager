

using DB.Core;
using System.ComponentModel;

namespace DB.Entities
{
    public class Tasks
    {
        public bool completed { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public int id { get; set; }

    }
}
