using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace desktop
{
    public class SocketAPI
    {
        const string EMPTY_BODY = "";
        
        private string context = "";
        private string body;
        private string task = "none";
        public SocketAPI(string context)
        {
            this.context = context;
        }

        private JObject buildRequest()
        {
            return new JObject(
                new JProperty("context", context),
                new JProperty("task", task),
                new JProperty("body", body)
            );
        }
        public SocketAPI Task(string task)
        {
            this.task = task;
            return this;
        }
        public JObject Body(string body)
        {
            this.body = body;
            return buildRequest();
        }
        public JObject Body()
        {
            this.body = EMPTY_BODY;
            return buildRequest();
        }
    }
}
