using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    class handleClient
    {
        TcpClient clientSocket;
        int clientNo;

        // 클라이언트 시작 함수
        public void startClient(TcpClient clientSocket, int clientNo)
        {
            this.clientSocket = clientSocket;
            this.clientNo = clientNo;

            Thread t_handler = new Thread(playGame);
            t_handler.IsBackground = true;
            t_handler.Start();
        }

        // 클라이언트로부터 받은 결과 처리 핸들러
        public delegate void MessageDisplayHandler(string message, int user_id);
        public event MessageDisplayHandler OnReceived;

        // player 숫자 처리 핸들러
        public delegate void CalculateClientCounter();
        public event CalculateClientCounter OnCalculated;

        // 연결 해제 핸들러
        public delegate void DisconnectedHandler(TcpClient clientSocket);
        public event DisconnectedHandler OnDisconnected;

        public int getClientNo() { return clientNo; }

        // 게임 플레이 중 결과 주고 받는 함수
        private void playGame()
        {
            NetworkStream stream = null;
            try
            {
                byte[] buffer = new byte[1024];
                string msg = string.Empty;
                int bytes = 0;
                int MessageCount = 0;

                while (true)
                {
                    // 클라이언트로부터 결과 받기
                    MessageCount++;
                    stream = clientSocket.GetStream();
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                    string[] parts = msg.Split('/');
                    string text = "[ " + parts[0] + " ] : " + parts[1] + " / " + parts[2];

                    if (OnReceived != null)
                        OnReceived(msg, int.Parse(parts[0]));
                }
            }
            catch (SocketException se)
            {
                Trace.WriteLine(string.Format("playGame - SocketException : {0}", se.Message));

                if (clientSocket != null)
                {
                    clientSocket.Close();
                    stream.Close();
                }

                if (OnCalculated != null)
                    OnCalculated();

            }
            catch (Exception ex)
            {
                Trace.WriteLine(string.Format("playGame - Exception : {0}", ex.Message));

                if (clientSocket != null)
                {
                    clientSocket.Close();
                    stream.Close();
                }

                if (OnCalculated != null)
                    OnCalculated();
            }
        }
    }
}
