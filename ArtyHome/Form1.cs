using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ArtyHome
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string incomingCommand;
        double getDegreeValue;
        bool anyIfTriggered = false;
        Random rnd = new Random();

        string[] positiveResponses = {
         "Understood, I'm on it.",
         "Alright, I'll get that done.",
         "Absolutely, I'm handling it.",
         "Of course, I'll take care of it.",
         "Okay, I do it now.",
         "Alright, I finish it.",
         "Yes, I handle it.",
         "Yes, I do that.",
         "Of course, I proceed.",
         "Confirmed, I adjust.",
         "Yes, I do it quickly.",
         "Okay, I execute the command."
        };

        string[] negativeResponses = {
          "I'm sorry, I can't do that.",
          "Apologies, I'm unable to comply.",
          "Unfortunately, I cannot do it.",
          "I'm afraid that's not possible.",
          "Unfortunately, I can't execute that command.",
          "Sorry, I'm not able to do that.",
          "I'm afraid I cannot perform that action.",
          "Sorry, it's not within my capabilities.",
          "Unfortunately, that's not allowed.",
          "I'm sorry, that's not supported.",
          "Regrettably, I cannot comply."
        };

        string[] turnOnAllOfLight = {
            "Okey sir, all the lights are on",
            "i got it, all the lights are on",
            "ok I got it done",
            "I did it, sir"
        };

        string[] turnOffAllOfLight = {
            "Okey sir, all the lights are off",
            "i got it, all the lights are off",
            "ok I got it done",
            "I did it, sir",
            "I turned off the lights"
        };

        string[] turnOnfirstFloorLight = {
            "Okey sir, the lights are on the first floor.",
            "Yes sir, the lights are on the first floor.",
            "i got it, the lights are on the first floor.",
            "ok I got it done",
            "I did it",
            "I turned on the lights"
        };

        string[] turnOffirstFloorLight = {
            "Okey sir, the lights are off the first floor.",
            "Yes sir, the lights are off the first floor.",
            "i got it, the lights are off the first floor.",
            "ok I got it done",
            "I did it",
            "I turned off the lights"
        };

        string[] turnOnSecondFloorLight = {
             "Okey sir, the lights are on the second floor.",
            "Yes sir, the lights are on the second floor.",
            "i got it, the lights are on the second floor.",
            "Ok, upstairs lights turned on",
            "ok I got it done",
            "I did it",
            "I turned on the lights"
        };

        string[] turnOffSecondFloorLight = {
             "Okey sir, the lights are off the second floor.",
            "Yes sir, the lights are off the second floor.",
            "i got it, the lights are off the second floor.",
            "Ok, upstairs lights turned off",
            "ok I got it done",
            "I did it",
            "I turned off the lights"
        };

        string[] turnOnHeater = { "okay i got it heater activated",
            "ok I'm running it" };

        string[] turnOffHeater = { "okay i got it heater disabled",
            "ok I'm stopping it" };

        string[] turnOnCooler = { "okay i got it cooler activated",
            "ok I'm running it" };

        string[] turnOffCooler = { "okay i got it cooler disabled",
            "ok I'm stopping it" };

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portSelectComboBox1.Items.Add(port);
                portSelectComboBox2.Items.Add(port); portSelectComboBox3.Items.Add(port);
            }
        }
      

        private string hear()
        {
            string pythonScriptPath = @"C:\Users\alikm\source\repos\Artifinity\soylenenKomut.py"; // python script yolu
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "C:\\Users\\alikm\\AppData\\Local\\Microsoft\\WindowsApps\\PythonSoftwareFoundation.Python.3.11_qbz5n2kfra8p0\\python.exe"; //python.exe yolu
                process.StartInfo.Arguments = pythonScriptPath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                incomingCommand = output;
                incomingCommand = incomingCommand.Trim().ToLower();
                return incomingCommand;
            }
        }
        static void SpeakResponse(string text)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.Speak(text);
            }
        }
        private void analysis()
        {

            #region Basit Konuşma İşlemleri
            if (incomingCommand.Contains("nasılsın") || incomingCommand.Contains("ne yapıyorsun") || incomingCommand.Contains("iyi misin"))
                SpeakResponse("Thank you for thinking of me. I'm doing just fine. How can I help you?");
            #endregion

            #region Işıklar


            #region Bütün ışıklar
            if (incomingCommand.Contains("ışıkları aç") || incomingCommand.Contains("lambaları aç"))
            {
                anyIfTriggered = true;
                SpeakResponse("what lights do you want me to turn on?");
                hear();
                if (incomingCommand.Contains("hepsini") || incomingCommand.Contains("tüm") || incomingCommand.Contains("bütün"))
                {
                    serialPort1.Write("1"); // bütün ışıkları aç -> 1

                    int index = rnd.Next(turnOnAllOfLight.Length);
                    SpeakResponse(turnOnAllOfLight[index]);
                }
            }
            if (incomingCommand.Contains("ışıkları kapat") || incomingCommand.Contains("lambaları kapat"))
            {
                anyIfTriggered = true;
                SpeakResponse("what lights do you want me to turn of?");
                hear();
                if (incomingCommand.Contains("hepsini") || incomingCommand.Contains("tüm") || incomingCommand.Contains("bütün"))
                {
                    serialPort1.Write("2"); // bütün ışıkları aç -> 2

                    int index = rnd.Next(turnOffAllOfLight.Length);
                    SpeakResponse(turnOffAllOfLight[index]);
                }
            }
            #endregion



            #region Birinci Kat
            if (incomingCommand.Contains("giriş katın ışıklarını aç") || incomingCommand.Contains("birinci katın ışıklarını aç") || incomingCommand.Contains("alt katın ışıklarını aç"))
            {
                anyIfTriggered = true;
                serialPort1.Write("3");

                int index = rnd.Next(turnOnfirstFloorLight.Length);
                SpeakResponse(turnOnfirstFloorLight[index]);
            }

            if (incomingCommand.Contains("giriş katın ışıklarını kapat") || incomingCommand.Contains("birinci katın ışıklarını kapat") || incomingCommand.Contains("alt katın ışıklarını kapat"))
            {
                anyIfTriggered = true;
                serialPort1.Write("4");

                int index = rnd.Next(turnOffirstFloorLight.Length);
                SpeakResponse(turnOffirstFloorLight[index]);
            }
            #endregion



            #region ikinci kat
            if (incomingCommand.Contains("üst katın ışıklarını aç"))
            {
                anyIfTriggered = true;
                serialPort1.Write("5");

                int index = rnd.Next(turnOnSecondFloorLight.Length);
                SpeakResponse(turnOnSecondFloorLight[index]);
            }

            if (incomingCommand.Contains("üst katın ışıklarını kapat") || incomingCommand.Contains("ikinci katın ışıklarını kapat"))
            {
                anyIfTriggered = true;
                serialPort1.Write("6"); 

                int index = rnd.Next(turnOffSecondFloorLight.Length);
                SpeakResponse(turnOffSecondFloorLight[index]);
            }
            #endregion

            #endregion

            #region ısıtıcı 
            if (incomingCommand.Contains("çalıştır") || incomingCommand.Contains("arttır") || incomingCommand.Contains("başlat") &&
                   incomingCommand.Contains("ısı") || incomingCommand.Contains("sıcaklık") || incomingCommand.Contains("sıcaklığı") ||
                   incomingCommand.Contains("ısıt") || incomingCommand.Contains("ısıyı") || incomingCommand.Contains("sıcaklığı")) {

                anyIfTriggered = true;
                if (getDegreeValue >= 27)
                {
                    SpeakResponse("The room is already hot, are you sure?");
                    hear();
                    if (incomingCommand.Contains("evet") || incomingCommand.Contains("eminim") || incomingCommand.Contains("aç") ||
                        incomingCommand.Contains("kesinlikle") || incomingCommand.Contains("tabi"))
                    {
                        int index = rnd.Next(turnOnHeater.Length);
                        SpeakResponse(turnOnHeater[index]);
                        serialPort2.Write("7");
                    }
                    else
                        SpeakResponse("Whatever.How else I can help you?");
                }
                else{
                    int index = rnd.Next(turnOnHeater.Length);
                    SpeakResponse(turnOnHeater[index]);
                    serialPort2.Write("7");
                }
            }

            if (incomingCommand.Contains("çalıştır") || incomingCommand.Contains("arttır") || incomingCommand.Contains("başlat"))
            {
                anyIfTriggered = true;
                SpeakResponse("please explain exactly what you want");
                hear();
                if(incomingCommand.Contains("çalıştır") || incomingCommand.Contains("arttır") || incomingCommand.Contains("başlat") && 
                   incomingCommand.Contains("ısı") || incomingCommand.Contains("sıcaklık") || incomingCommand.Contains("sıcaklığı") ||
                   incomingCommand.Contains("ısıt") || incomingCommand.Contains("ısıyı") || incomingCommand.Contains("sıcaklığı")){

                    if (getDegreeValue >= 27)
                    {
                        SpeakResponse("The room is already hot, are you sure?");
                        hear();
                        if (incomingCommand.Contains("evet") || incomingCommand.Contains("eminim") || incomingCommand.Contains("aç") ||
                            incomingCommand.Contains("kesinlikle") || incomingCommand.Contains("tabi"))
                        {
                            int index = rnd.Next(turnOnHeater.Length);
                            SpeakResponse(turnOnHeater[index]);
                            serialPort2.Write("7");
                        }
                        else
                            SpeakResponse("How else I can help you?");
                    }
                    else
                    {
                        int index = rnd.Next(turnOnHeater.Length);
                        SpeakResponse(turnOnHeater[index]);
                        serialPort2.Write("7");
                    }

                }
            }

            if (incomingCommand.Contains("kapat") || incomingCommand.Contains("durdur") || incomingCommand.Contains("bitir"))
            {
                anyIfTriggered = true;
                SpeakResponse("please explain exactly what you want");
                hear();
                if (incomingCommand.Contains("kapat") || incomingCommand.Contains("durdur") || incomingCommand.Contains("bitir") &&
                    incomingCommand.Contains("ısı") || incomingCommand.Contains("ısıtıcı") || incomingCommand.Contains("ısıtıcıyı") || incomingCommand.Contains("ısıt") ||
                    incomingCommand.Contains("klima") || incomingCommand.Contains("klimayı"))
                {
                    int index = rnd.Next(turnOffHeater.Length);
                    SpeakResponse(turnOffHeater[index]);
                    serialPort2.Write("8");
                }
            }
            #endregion

            #region soğutucu
            if (incomingCommand.Contains("çalıştır") || incomingCommand.Contains("arttır") || incomingCommand.Contains("başlat"))
            {
                anyIfTriggered = true;
                SpeakResponse("please explain exactly what you want");
                hear();
                if (incomingCommand.Contains("çalıştır") || incomingCommand.Contains("arttır") || incomingCommand.Contains("başlat") &&
                   incomingCommand.Contains("pervane") || incomingCommand.Contains("klima") || incomingCommand.Contains("soğutucu") ||
                   incomingCommand.Contains("pervaneyi") || incomingCommand.Contains("klimayı") || incomingCommand.Contains("soğutucuyu"))
                {
                    if (getDegreeValue <= 18)
                    {
                        SpeakResponse("The room is already cold, are you sure?");
                        hear();
                        if (incomingCommand.Contains("evet") || incomingCommand.Contains("eminim") || incomingCommand.Contains("aç") ||
                            incomingCommand.Contains("kesinlikle") || incomingCommand.Contains("tabi"))
                        {
                            int index = rnd.Next(turnOnCooler.Length);
                            SpeakResponse(turnOnCooler[index]);
                            serialPort2.Write("9");
                        }
                        else
                            SpeakResponse("How else I can help you?");
                    }
                    else
                    {
                        int index = rnd.Next(turnOnCooler.Length);
                        SpeakResponse(turnOnCooler[index]);
                        serialPort2.Write("9");
                    }

                }
            }

            if (incomingCommand.Contains("çalıştır") || incomingCommand.Contains("başlat") &&
                incomingCommand.Contains("pervane") || incomingCommand.Contains("klima") || incomingCommand.Contains("soğutucu") ||
                incomingCommand.Contains("pervaneyi") || incomingCommand.Contains("klimayı") || incomingCommand.Contains("soğutucuyu")) {

                anyIfTriggered = true;
                if (getDegreeValue <= 18)
                {
                    SpeakResponse("The room is already cold, are you sure?");
                    hear();
                    if (incomingCommand.Contains("evet") || incomingCommand.Contains("eminim") || incomingCommand.Contains("aç") ||
                        incomingCommand.Contains("kesinlikle") || incomingCommand.Contains("tabi"))
                    {
                        int index = rnd.Next(turnOnCooler.Length);
                        SpeakResponse(turnOnCooler[index]);
                        serialPort2.Write("9");
                    }
                    else
                        SpeakResponse("How else I can help you?");
                }
                else
                {
                    int index = rnd.Next(turnOnCooler.Length);
                    SpeakResponse(turnOnCooler[index]);
                    serialPort2.Write("9");
                }
            }

            if (incomingCommand.Contains("kapat") || incomingCommand.Contains("bitir") || incomingCommand.Contains("durdur"))
            {
                anyIfTriggered = true;
                SpeakResponse("please explain exactly what you want");
                hear();
                if (incomingCommand.Contains("kapat") || incomingCommand.Contains("durdur") &&
                   incomingCommand.Contains("pervane") || incomingCommand.Contains("klima") || incomingCommand.Contains("soğut") || incomingCommand.Contains("soğutucu") ||
                   incomingCommand.Contains("pervaneyi") || incomingCommand.Contains("klimayı") || incomingCommand.Contains("soğutucuyu"))
                {
                    int index = rnd.Next(turnOnCooler.Length);
                    SpeakResponse(turnOnCooler[index]);
                    serialPort2.Write("10");
                }
            }

            #endregion

            #region kapılar
            if (incomingCommand.Contains("kapıyı aç"))
            {
                anyIfTriggered = true;

                serialPort2.Write("11");
                SpeakResponse("Okay, i did it");
            }
            if (incomingCommand.Contains("kapıyı kapat"))
            {
                anyIfTriggered = true;

                serialPort2.Write("12");
                SpeakResponse("Okay, i did it");
            }
            #endregion

            #region Tanımlanmayan / Anlaşılmayan Komut 
            if (!anyIfTriggered)
            {
                SpeakResponse("Please explain again what you want.");
            }
            #endregion

        }

        private void micButton_Click(object sender, EventArgs e)
        {
            hear();
            analysis();
        }
    }
}
