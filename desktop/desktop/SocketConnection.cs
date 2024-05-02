using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace desktop
{
    internal class SocketConnection
    {
        private WebSocket connection;
        private JObject response = new JObject();
        private void setResponse(JObject response) { this.response = response; }
        public JObject getResponse() { return new JObject(
                                                new JProperty("response", response),
                                                new JProperty("cache",Form1.getFrontEndCache())); }

        private JObject responseListener
        {
            get { return response; }
            set
            {
                response = value;
                OnReceived(); // Quando definir valor, também executará a trigger do evento
            }
        }
        public event EventHandler Received;
        protected virtual void OnReceived() { Received?.Invoke(this, EventArgs.Empty); }
       

        public SocketConnection(string url, int port) {
            connection = new WebSocket("ws://"+ url +":"+ port);
            connection.Connect();
            connection.OnMessage += (s, e) => setResponse(JObject.Parse(e.Data));
        }
        public bool isConnected() { return connection.IsAlive; }
        public JObject send(JObject request)
        {
            if (!isConnected()) return JObject.Parse(@"{'status':503}");
            
            string stringRequest= request.ToString();
            connection.Send(stringRequest);
            
            return JObject.Parse(@"{'status':200}");
        }
        
    }
}
