using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace desktop
{
    public class SocketAPI
    {
        private string request_method;
        private string request_route = "";
        private JObject request_body;
        private JObject response = new JObject();

        private UserControl CurrentScreen;

        public SocketAPI()
        {    
            request_method = "undefined";
        }
        private JObject buildRequest()
        {
            return new JObject(
                new JProperty("method", request_method),
                new JProperty("body", request_body),
                new JProperty("route", request_route));
        }


        public SocketAPI get()
        {
            request_method = "GET";
            return this;
        }
        public SocketAPI post()
        {
            request_method = "POST";
            return this;
        }
        public SocketAPI put()
        {
            request_method = "PUT";
            return this;
        }
        public SocketAPI delete()
        {
            request_method = "DELETE";
            return this;
        }

        public JObject Listas(string nome)
        {
            request_route = "listas";
            switch (request_method)
            {
                case "GET":
                    request_body = new JObject();
                    return buildRequest();
                default:
                    request_body = new JObject();
                    return new JObject("status", 400);

            }

        }
        public JObject Listas()
        {
            request_route = "listas";
            request_body = new JObject();
            return buildRequest();
        }
    }
}
