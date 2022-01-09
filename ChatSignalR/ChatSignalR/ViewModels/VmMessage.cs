using ChatSignalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSignalR.ViewModels
{
    public class VmMessage
    {
        public List<Message> Messages { get; set; }
        public string SenderId { get; set; }
        public CustomUser User { get; set; }
    }
}
