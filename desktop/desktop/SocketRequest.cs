
using Newtonsoft.Json.Linq;

namespace desktop
{
    public class SocketRequest
    {
        private const string URL = "127.0.0.1";
        private const int PORT = 5000;
        private SocketConnection socket;

        private string request_method;
        private string request_route = "";

        private JObject request_body;
        private int request_status;
        public SocketRequest()
        {
            socket = new SocketConnection(URL,PORT);
            request_method = "undefined";
            socket.Received += (sender, args) => OnResponse();
        }
        protected virtual void OnResponse()
        {
            Response?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler Response;
        public JObject getResponse()
        {
            return socket.getResponse();
        }

        private JObject sendRequest()
        {            
            JObject request = new JObject(
                                    new JProperty("method",request_method), 
                                    new JProperty("body", request_body),
                                    new JProperty("route", request_route),
                                    new JProperty("origin", Form1.tela_atual));
            return socket.send(request);
        }
        

        public SocketRequest get()
        {
            request_method = "GET";
            return this;
        }
        public SocketRequest post()
        {
            request_method = "POST";
            return this;
        }
        public SocketRequest put()
        {
            request_method = "PUT";
            return this;
        }
        public SocketRequest delete()
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
                    return sendRequest();
                default:
                    request_body = new JObject();
                    return new JObject("status",400);

            }

        }
        public JObject Listas()
        {
            request_route = "listas";
            request_body = new JObject();
            return sendRequest();
        }
    }
}
