//wygenerowane
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//moje
using System.IO.Ports;

namespace SterowanieOswietleniem
{
    public partial class SterowanieOswietleniem : Form
    {
       
        //zmienne użytkownika
        System.IO.Ports.SerialPort port;
        delegate void Delegat1();
        Delegat1 moj_del1;

        public SterowanieOswietleniem()
        {
            InitializeComponent();
            //inicjalizacja zmiennej port z domyślnymi wartościami
            port = new SerialPort();
            port.DtrEnable = true;
            //ustawienie timeoutów aby program się nie wieszał
            port.ReadTimeout = 500;
            port.WriteTimeout = 500;

            Opcje.Enter += new EventHandler(Opcje_Enter);
            port.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            moj_del1 = new Delegat1(WpiszOdebrane); 
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            rtbTerminal.Invoke(moj_del1);
        }

        int bufferData = 0;
        private void WpiszOdebrane()
        {
            bufferData = port.ReadByte();
            DodajKolorowy(rtbTerminal, bufferData.ToString() + " ", System.Drawing.Color.Blue);
            sprawdz(bufferData);
        }

        private void DodajKolorowy(System.Windows.Forms.RichTextBox RichTextBox, string Text, System.Drawing.Color Color)
        {
            var StartIndex = RichTextBox.TextLength;
            RichTextBox.AppendText(Text);
            var EndIndex = RichTextBox.TextLength;
            RichTextBox.Select(StartIndex, EndIndex - StartIndex);
            RichTextBox.SelectionColor = Color;
        }

        void Opcje_Enter(object sender, EventArgs e)
        {
            //aktualizacja list
            this.cbName.Items.Clear();
            this.cbParity.Items.Clear();
            this.cbStop.Items.Clear();
            foreach (String s in SerialPort.GetPortNames()) this.cbName.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(Parity))) this.cbParity.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(StopBits))) this.cbStop.Items.Add(s);

            //aktualizacja nazw
            cbName.Text = port.PortName.ToString();
            cbBaud.Text = port.BaudRate.ToString();
            cbData.Text = port.DataBits.ToString();
            cbParity.Text = port.Parity.ToString();
            cbStop.Text = port.StopBits.ToString();
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                DodajKolorowy(rtbTerminal, ((Int32)numericSend.Value).ToString("X") + " ", System.Drawing.Color.Black);
                Byte[] tosend = { (Byte) numericSend.Value};
                port.Write(tosend, 0, 1);
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void butDomyslne_Click(object sender, EventArgs e)
        {
            this.cbName.Text = "COM5";
            this.cbBaud.Text = "115200";
            this.cbData.Text = "8";
            this.cbParity.Text = "None";
            this.cbStop.Text = "One";
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            cbName.Text = port.PortName.ToString();
            cbBaud.Text = port.BaudRate.ToString();
            cbData.Text = port.DataBits.ToString();
            cbParity.Text = port.Parity.ToString();
            cbStop.Text = port.StopBits.ToString();
        }

        private void pbStatus_Click(object sender, EventArgs e)
        {
            
        }

        bool lpSpalone = false;
        bool ltSpalone = false;
        bool ppSpalone = false;
        bool ptSpalone = false;
        int licznik1 = 0;
        int licznik2 = 0;

        bool wlaczonyLewyKierunkowskaz = false;
        bool wlaczonyPrawyKierunkowskaz = false;
        bool wlaczoneLewePrzednieSwiatlo = false;
        bool wlaczonePrawePrzednieSwiatlo = false;
        bool wlaczonePraweTylneSwiatlo = false;
        bool wlaczoneLeweTylneSwiatlo = false;
        bool wlaczoneSwiatlaAwaryjne = false;

        private void wlaczKierunkowskazLewy()
        {
            lpKierunkowskaz.BackColor = Color.Orange;
            ltKierunkowskaz.BackColor = Color.Orange;
            miganieKierunkowskazu.Start();
            wlaczonyLewyKierunkowskaz = true;
        }

        private void wylaczKierunkowskazLewy()
        {
            miganieKierunkowskazu.Stop();
            licznik1 = 0;
            lpKierunkowskaz.BackColor = Color.Gray;
            ltKierunkowskaz.BackColor = Color.Gray;
            wlaczonyLewyKierunkowskaz = false;
        }

        private void wlaczKierunkowskazPrawy()
        {
            ppKierunkowskaz.BackColor = Color.Orange;
            ptKierunkowskaz.BackColor = Color.Orange;
            miganieKierunkowskazu2.Start();
            wlaczonyPrawyKierunkowskaz = true;
        }

        private void wylaczKierunkowskazPrawy()
        {
            miganieKierunkowskazu2.Stop();
            licznik2 = 0;
            ppKierunkowskaz.BackColor = Color.Gray;
            ptKierunkowskaz.BackColor = Color.Gray;
            wlaczonyPrawyKierunkowskaz = false;
        }

        private void wlaczSwiatlaPrzednie()
        {
            lpSwiatlo.BackColor = System.Drawing.Color.Gold;
            ppSwiatlo.BackColor = System.Drawing.Color.Gold;
            wlaczoneLewePrzednieSwiatlo = true;
            wlaczonePrawePrzednieSwiatlo = true;
        }

        private void wylaczSwiatlaPrzednie()
        {
            lpSwiatlo.BackColor = System.Drawing.Color.Gray;
            ppSwiatlo.BackColor = System.Drawing.Color.Gray;
            wlaczoneLewePrzednieSwiatlo = false;
            wlaczonePrawePrzednieSwiatlo = false;
        }

        private void wlaczSwiatlaTylne()
        {
            ltSwiatlo.BackColor = System.Drawing.Color.Red;
            ptSwiatlo.BackColor = System.Drawing.Color.Red;
            wlaczoneLeweTylneSwiatlo = true;
            wlaczonePraweTylneSwiatlo = true;
        }

        private void wylaczSwiatlaTylne()
        {
            ltSwiatlo.BackColor = System.Drawing.Color.Gray;
            ptSwiatlo.BackColor = System.Drawing.Color.Gray;
            wlaczoneLeweTylneSwiatlo = false;
            wlaczonePraweTylneSwiatlo = false;
        }

        private void swiatlaPrzod(object sender, EventArgs e)
        {
            int wlaczLED= 49;
            if (port.IsOpen)
            {
                DodajKolorowy(rtbTerminal, wlaczLED.ToString(), System.Drawing.Color.Black);
                byte[] tosend = BitConverter.GetBytes(wlaczLED);
                port.Write(tosend, 0, 1);

                if (wlaczoneLewePrzednieSwiatlo == true || wlaczonePrawePrzednieSwiatlo == true)
                {
                    wylaczSwiatlaPrzednie();
                }
                else if (wlaczoneLewePrzednieSwiatlo == false || wlaczonePrawePrzednieSwiatlo == false)
                {
                    wlaczSwiatlaPrzednie();
                }
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");

           
        }

        private void swiatlaTyl(object sender, EventArgs d)
        {
            int wlaczLED = 50;
            if (port.IsOpen)
            {
                DodajKolorowy(rtbTerminal, wlaczLED.ToString(), System.Drawing.Color.Black);
                byte[] tosend = BitConverter.GetBytes(wlaczLED);
                port.Write(tosend, 0, 1);

                if (wlaczonePraweTylneSwiatlo == false || wlaczoneLeweTylneSwiatlo == false)
                {
                    wlaczSwiatlaTylne();
                    
                }
                else if (wlaczonePraweTylneSwiatlo == true || wlaczoneLeweTylneSwiatlo == true)
                {

                    wylaczSwiatlaTylne();
                }

            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        

        private void kierunkowskazLewy(object sender, EventArgs e)
        {
            int wlaczLED = 51;
            if (port.IsOpen)
            {
                DodajKolorowy(rtbTerminal, wlaczLED.ToString(), System.Drawing.Color.Black);
                byte[] tosend = BitConverter.GetBytes(wlaczLED);
                port.Write(tosend, 0, 1);

                if (wlaczonyPrawyKierunkowskaz == true && wlaczonyLewyKierunkowskaz == true)
                {
                    wylaczKierunkowskazPrawy();
                    wylaczKierunkowskazLewy();
                }
                else if (wlaczonyPrawyKierunkowskaz == true)
                {
                    wylaczKierunkowskazPrawy();
                }

                if (wlaczonyLewyKierunkowskaz == false)
                {
                    wlaczKierunkowskazLewy();
                }
                else if (wlaczonyLewyKierunkowskaz == true)
                {
                    wylaczKierunkowskazLewy();
                }   
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
            
        }


        private void kierunkowskazPrawy(object sender, EventArgs e)
        {
            int wlaczLED = 52;
            if (port.IsOpen)
            {
                DodajKolorowy(rtbTerminal, wlaczLED.ToString(), System.Drawing.Color.Black);
                byte[] tosend = BitConverter.GetBytes(wlaczLED);
                port.Write(tosend, 0, 1);

                if (wlaczonyPrawyKierunkowskaz == true && wlaczonyLewyKierunkowskaz == true)
                {
                    wylaczKierunkowskazLewy();
                    wylaczKierunkowskazPrawy();
                }
                else if (wlaczonyLewyKierunkowskaz == true)
                {
                    wylaczKierunkowskazLewy();
                }

                if (wlaczonyPrawyKierunkowskaz == false)
                {
                    wlaczKierunkowskazPrawy();
                }
                else if (wlaczonyPrawyKierunkowskaz == true)
                {
                    wylaczKierunkowskazPrawy();
                }
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");

        }

        private void pbStatus_Click_1(object sender, EventArgs e)
        {
            //jeżeli połączenie jest aktywne to je kończymy, zmieniamy kolor na red i zmieniamy napis
            if (port.IsOpen)
            {
                pbStatus.BackColor = System.Drawing.Color.Red;
                port.Close();
                labStatus.Text = "Brak połączenia (teraz można zmieniać opcje połączenia)";
                DodajKolorowy(rtbTerminal, "\nZakończono połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
            }
            //w przeciwnym wypadku włączamy połączenie, zmieniamy kolor na zielony i zmieniamy napis
            else
            {
                //połączenie może nie być możliwe dlatego należy się zabezpieczyć na wypadek błędu
                try
                {
                    //najpierw przepisujemy do portu parametry z opcji
                    port.PortName = this.cbName.Text;
                    port.BaudRate = Int32.Parse(this.cbBaud.Text);
                    port.DataBits = Int32.Parse(this.cbData.Text);
                    port.Parity = (Parity)Enum.Parse(typeof(Parity), this.cbParity.Text);
                    port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cbStop.Text);
                    //a następnie uruchamiamy port
                    port.Open();
                    //po uruchomieniu zmieniamy elementy graficzne interfejsu
                    pbStatus.BackColor = System.Drawing.Color.Green;
                    labStatus.Text = "Aktywne połączenie (port:" + port.PortName.ToString() + ", prędkość: " + port.BaudRate.ToString() + ", bity danych: " +
                    port.DataBits.ToString() + "\n bity stopu: " + port.StopBits.ToString() + ", parzystość: " + port.Parity.ToString() + ")";
                    DodajKolorowy(rtbTerminal, "Rozpoczęto połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
                }
                //jeżeli nastąpi błąd to go przechwycimy i wyświetlimy stosowny komunikat
                catch (Exception exc)
                {
                    MessageBox.Show("Błąd połączenia:\n" + exc.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (licznik1 == 0)
            {
               if(!lpSpalone) lpKierunkowskaz.BackColor = Color.Khaki;
                if (!ltSpalone) ltKierunkowskaz.BackColor = Color.Khaki;
            }
            if(licznik1 == 1)
            {
                if (!lpSpalone) lpKierunkowskaz.BackColor = Color.Orange;
                if (!ltSpalone) ltKierunkowskaz.BackColor = Color.Orange;
            }

            licznik1 = (licznik1 + 1) % 2;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (licznik2 == 0)
            {
                if (!ppSpalone) ppKierunkowskaz.BackColor = Color.Khaki;
                if (!ptSpalone) ptKierunkowskaz.BackColor = Color.Khaki;
            }
            if (licznik2 == 1)
            {
                if (!ppSpalone) ppKierunkowskaz.BackColor = Color.Orange;
                if (!ptSpalone) ptKierunkowskaz.BackColor = Color.Orange;
            }

            licznik2 = (licznik2 + 1) % 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //jeżeli połączenie jest aktywne to wyswietlamy komunikat
            if (port.IsOpen)
            {
                MessageBox.Show("Połączenie już jest aktywne!");
            }
            //w przeciwnym wypadku włączamy połączenie
            else
            {
                //połączenie może nie być możliwe dlatego należy się zabezpieczyć na wypadek błędu
                try
                {
                    //najpierw przepisujemy do portu parametry z opcji
                    port.PortName = this.cbName.Text;
                    port.BaudRate = Int32.Parse(this.cbBaud.Text);
                    port.DataBits = Int32.Parse(this.cbData.Text);
                    port.Parity = (Parity)Enum.Parse(typeof(Parity), this.cbParity.Text);
                    port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cbStop.Text);
                    //a następnie uruchamiamy port
                    port.Open();
                    MessageBox.Show("Połączono pomyślnie");
                    pbStatus.BackColor = System.Drawing.Color.Green;
                    labStatus.Text = "Aktywne połączenie (port:" + port.PortName.ToString() + ", prędkość: " + port.BaudRate.ToString() + ", bity danych: " +
                    port.DataBits.ToString() + "\n bity stopu: " + port.StopBits.ToString() + ", parzystość: " + port.Parity.ToString() + ")";
                    DodajKolorowy(rtbTerminal, "Rozpoczęto połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
                }
                //jeżeli nastąpi błąd to go przechwycimy i wyświetlimy stosowny komunikat
                catch (Exception exc)
                {
                    MessageBox.Show("Błąd połączenia:\n" + exc.Message);
                }
            }
        }

        private void TrybAuto_Click(object sender, EventArgs e)
        {
            int wlaczLED = 53;
            if (port.IsOpen)
            {
                DodajKolorowy(rtbTerminal, wlaczLED.ToString(), System.Drawing.Color.Black);
                byte[] tosend = BitConverter.GetBytes(wlaczLED);
                port.Write(tosend, 0, 1);

                //jesli klikniemy tryb automatyczny i przednie swiatla beda wlaczone, to je wylaczy
                if (wlaczonePrawePrzednieSwiatlo == true || wlaczoneLewePrzednieSwiatlo == true)
                {
                    wylaczSwiatlaPrzednie();
                }
                //jesli klikniemy tryb automatyczny i przednie swiatla beda wylaczone, to je wlaczy
                else if (wlaczonePrawePrzednieSwiatlo == false || wlaczoneLewePrzednieSwiatlo == false)
                {
                    wlaczSwiatlaPrzednie();
                }
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void Awaryjne_Click(object sender, EventArgs e)
        {
            int wlaczLED = 54;
            if (port.IsOpen)
            {
                DodajKolorowy(rtbTerminal, wlaczLED.ToString(), System.Drawing.Color.Black);
                byte[] tosend = BitConverter.GetBytes(wlaczLED);
                port.Write(tosend, 0, 1);
                
                if (wlaczoneSwiatlaAwaryjne == true) //jesli awaryjne sa wlaczone
                {
                    wylaczKierunkowskazLewy();
                    wylaczKierunkowskazPrawy();
                    wlaczoneSwiatlaAwaryjne = false;
                }
                else if (wlaczoneSwiatlaAwaryjne == false) //jesli awaryjne sa wylaczone
                {
                    //najpierw wylaczamy wszystkie kierunki...
                    if (wlaczonyLewyKierunkowskaz == true)  
                    {
                        wylaczKierunkowskazLewy();
                        
                    }
                    if(wlaczonyPrawyKierunkowskaz == true)
                    {
                        wylaczKierunkowskazPrawy();
                    }

                    //...i wlaczamy oba naraz spowrotem
                    wlaczKierunkowskazLewy();
                    wlaczKierunkowskazPrawy();
                    wlaczoneSwiatlaAwaryjne = true;
                }
            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");

        }
        private void sprawdz(int bufferData)
        {
            //------------------------------------------------------------------------------------------------------------------------
            //swiatla przednie
            if (bufferData == 49) //przod lewy spalony
            {
                lpSwiatlo.BackColor = Color.Black;
            }
            if (bufferData == 50) //przod lewy dziala 
            {
                lpSwiatlo.BackColor = Color.Gold;
            }

            if (bufferData == 51) // przod prawy spalony
            {
                ppSwiatlo.BackColor = Color.Black;
            }
            if (bufferData == 52) // przod prawy dziala
            {
                ppSwiatlo.BackColor = Color.Gold;
            }

            //------------------------------------------------------------------------------------------------------------------------
            //swiatla tylne
            if (bufferData == 53) //tyl lewy spalony
            {
                ltSwiatlo.BackColor = Color.Black;
            }
            if (bufferData == 54) //tyl lewy dziala 
            {
                ltSwiatlo.BackColor = Color.Red;
            }

            if (bufferData == 55) // tyl prawy spalony
            {
                ptSwiatlo.BackColor = Color.Black;
            }
            if (bufferData == 56) // tyl prawy dziala
            {
                ptSwiatlo.BackColor = Color.Red;
            }

            //------------------------------------------------------------------------------------------------------------------------
            //kierunki lewe
            if (bufferData == 57) //przedni lewy kierunkowskaz spalony
            {
                lpKierunkowskaz.BackColor = Color.Black;
                lpSpalone = true;
            }
            if (bufferData == 58) //przedni lewy kierunkowskaz dziala 
            {
                lpSpalone = false;
            }

            if (bufferData == 59) //tylni lewy kierunkowskaz spalony
            {
               ltKierunkowskaz.BackColor = Color.Black;
                ltSpalone = true;
            }
            if (bufferData == 60) //tylni lewy kierunkowskaz dziala
            {
                ltSpalone = false;
            }


            //------------------------------------------------------------------------------------------------------------------------
            //kierunki prawe
            if (bufferData == 61) //przedni prawy kierunkowskaz spalony
            {
                ppKierunkowskaz.BackColor = Color.Black;
                ppSpalone = true;
            }
            if (bufferData == 62) //przedni prawy kierunkowskaz dziala 
            {
                ppSpalone = false;
            }

            if (bufferData == 63) //tylni prawy kierunkowskaz spalony
            {
                ptKierunkowskaz.BackColor = Color.Black;
                ptSpalone = true;
            }
            if (bufferData == 64) { 
                ptSpalone = false;
            }

            //------------------------------------------------------------------------------------------------------------------------
            //zapalenie/gaszenie swiatel przod poprzez tryb automatyczny

            if (bufferData == 65) //jest ciemno, zapal przednie lampy!
            {
                wlaczSwiatlaPrzednie();
                wlaczonePrawePrzednieSwiatlo = true;
                wlaczoneLewePrzednieSwiatlo = true;
            }
            if (bufferData == 66) //jest jasno, czujnik zgasil przednie lampy!
            {
                wylaczSwiatlaPrzednie();
                wlaczonePrawePrzednieSwiatlo = false;
                wlaczoneLewePrzednieSwiatlo = false;
            }
        }

    }
}
