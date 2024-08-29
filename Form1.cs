using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener server = null; // 서버
        TcpClient clientSocket = null; // 소켓
        static int counter = 0; // 사용자 수
        string date; // 날짜

        // 각 클라이언트마다 리스트에 추가
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        int[,] answerArr = new int[1, 4]; // 방 개수 1개 -> 방 구현 필요


        /* 랜덤 배열을 방 개수만큼 생성하는 함수 */
        private void SetRandomNumber()
        {
            Random randomObj = new Random();

            for (int i = 0; i < answerArr.GetLength(0); i++)
            {
                for (int j = 0; j < answerArr.GetLength(1); j++)
                {
                    answerArr[i, j] = randomObj.Next(1, 6);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            SetRandomNumber();

            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Loopback, 9999); // 서버 접속 ip, 포트 다른 컴퓨터와 통신하려면 바꿔야 함
            clientSocket = default(TcpClient); 
            server.Start();
            DisplayText(">> 서버 시작");

            while(true)
            {
                try
                {
                    // 클라이언트 추가
                    counter++;
                    clientSocket = server.AcceptTcpClient();
                    DisplayText(">> 클라이언트 접속 허용");

                    // 클라이언트에게 정답 배열 보내기
                    NetworkStream stream = clientSocket.GetStream();

                    int row = 0; // 방 번호? 
                    string ans = string.Join(" ", Enumerable.Range(0, answerArr.GetLength(1)).Select(col => answerArr[row, col].ToString())); // 정답 배열을 string으로 변환

                    byte[] buffer = Encoding.Unicode.GetBytes(ans);

                    // 서버 화면에 띄우기
                    string displayans = (row + 1).ToString() + "번 방 정답 전송: " + ans;
                    DisplayText(ans);

                    // 클라이언트에게 전송
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Flush();

                    handleClient h_client = new handleClient(); // 클라이언트 추가

                    clientList.Add(clientSocket, counter.ToString()); // 클라이언트 리스트에 추가

                    // 핸들러 등록
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
                    h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);

                    h_client.startClient(clientSocket, counter); // 클라이언트 시작
                }
                catch(SocketException se) { break; }
                catch(Exception ex) { break; }
            }

            clientSocket.Close();
            server.Stop();
        }


        /* 클라이언트 접속 해제 핸들러 */
        void h_client_OnDisconnected(TcpClient clientSocket)
        {
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }


        /* 클라이언트로부터 받은 데이터 */
        private void OnReceived(string message, int user_id)
        {
            if (message.Equals("leaveGame")) // 게임 끝
            {
                string displayMessage = "leave user: " + message;
                DisplayText(displayMessage);
                SendResultRoom(displayMessage, user_id, true);
            }
            else
            {
                DisplayText(message);
                SendResultRoom(message, user_id, true);
            }
        }

        public void SendResultRoom(string message, int user_id, bool flag)
        {
            foreach(var pair in clientList)
            {
                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                    if (message.Equals("leaveGame")) // 게임 종료
                        buffer = Encoding.Unicode.GetBytes(user_id.ToString() + " 님이 게임을 종료했습니다. ");
                    else
                        buffer = Encoding.Unicode.GetBytes(message);
                }
                else
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }

                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }

        /* 서버 화면에 출력 */
        public void DisplayText(string text)
        {
            /*
             string[] parts = text.Split('/');
            text = "[ " + parts[0] + " ] : " + parts[1] + " / " + parts[2];*/

            if (logTb.InvokeRequired)
            {
                logTb.BeginInvoke(new MethodInvoker(delegate
                {
                    logTb.AppendText(text + Environment.NewLine);
                }));
            }
            else
                logTb.AppendText(text + Environment.NewLine);
        }
    }
}
