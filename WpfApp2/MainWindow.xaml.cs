using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Linq;
using System;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Web;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private bool button1WasClicked = false;
        private bool button2WasClicked = false;
        private bool button3WasClicked = false;
        private bool button4WasClicked = false;
        private bool buttonB1WasClicked = false;
        private bool buttonB2WasClicked = false;
        private bool buttonB3WasClicked = false;
        private bool buttonB4WasClicked = false;
        private bool buttonC1WasClicked = false;
        private bool buttonC2WasClicked = false;
        private bool buttonC3WasClicked = false;
        private bool buttonC4WasClicked = false;
        private bool buttonD1WasClicked = false;
        private bool buttonD2WasClicked = false;
        private bool buttonD3WasClicked = false;
        private bool buttonD4WasClicked = false;
        private string seats = "All seats are reserved";
        List<Seat> myList = new List<Seat>();


        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to MovieMax!");

         

            myList.Insert(0, new Seat {  Number = "A1" });
            myList.Insert(1, new Seat { Number = "A2" });
            myList.Insert(2, new Seat { Number = "A3" });
            myList.Insert(3, new Seat { Number = "A4" });
            myList.Insert(4, new Seat { Number = "B1" });
            myList.Insert(5, new Seat { Number = "B2" });
            myList.Insert(6, new Seat { Number = "B3" });
            myList.Insert(7, new Seat { Number = "B4" });
            myList.Insert(8, new Seat { Number = "C1" });
            myList.Insert(9, new Seat { Number = "C2" });
            myList.Insert(10, new Seat { Number = "C3" });
            myList.Insert(11, new Seat { Number = "C4" });
            myList.Insert(12, new Seat { Number = "D1" });
            myList.Insert(13, new Seat { Number = "D2" });
            myList.Insert(14, new Seat { Number = "D3" });
            myList.Insert(15, new Seat { Number = "D4" });

        }


        private void Btn_Confirm_Seat_Click(object sender, RoutedEventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Please type a name");
            }

            else if (button1WasClicked == false && button2WasClicked == false && button3WasClicked == false && button4WasClicked == false
                && buttonB1WasClicked == false && buttonB2WasClicked == false && buttonB3WasClicked == false && buttonB4WasClicked == false
                 && buttonC1WasClicked == false && buttonC2WasClicked == false && buttonC3WasClicked == false && buttonC4WasClicked == false
                 && buttonD1WasClicked == false && buttonD2WasClicked == false && buttonD3WasClicked == false && buttonD4WasClicked == false)
            {
                MessageBox.Show("Please choose a seat");
            }

            else if (button1WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(0);
                myList.Insert(0, new Seat { Name = txtName.Text });
                btn_A1.Content = myList[0].Name;
                MessageBox.Show("Seat reserved!");
                button1WasClicked = false;
                btn_A1.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }
            else if (button2WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(1);
                myList.Insert(1, new Seat { Name = txtName.Text });
                btn_A2.Content = myList[1].Name;
                MessageBox.Show("Seat reserved!");
                button2WasClicked = false;
                btn_A2.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (button3WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(2);
                myList.Insert(2, new Seat { Name = txtName.Text });
                btn_A3.Content = myList[2].Name;
                MessageBox.Show("Seat reserved!");
                button3WasClicked = false;
                btn_A3.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (button4WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(3);
                myList.Insert(3, new Seat { Name = txtName.Text });
                btn_A4.Content = myList[3].Name;
                MessageBox.Show("Seat reserved!");
                button4WasClicked = false;
                btn_A4.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }
            else if (buttonB1WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(4);
                myList.Insert(4, new Seat { Name = txtName.Text });
                btn_B1.Content = myList[4].Name;
                MessageBox.Show("Seat reserved!");
                buttonB1WasClicked = false;
                btn_B1.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }
            else if (buttonB2WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(5);
                myList.Insert(5, new Seat { Name = txtName.Text });
                btn_B2.Content = myList[5].Name;
                MessageBox.Show("Seat reserved!");
                buttonB2WasClicked = false;
                btn_B2.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (buttonB3WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(6);
                myList.Insert(6, new Seat { Name = txtName.Text });
                btn_B3.Content = myList[6].Name;
                MessageBox.Show("Seat reserved!");
                buttonB3WasClicked = false;
                btn_B3.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (buttonB4WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(7);
                myList.Insert(7, new Seat { Name = txtName.Text });
                btn_B4.Content = myList[7].Name;
                MessageBox.Show("Seat reserved!");
                buttonB4WasClicked = false;
                btn_B4.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }
            else if (buttonC1WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(8);
                myList.Insert(8, new Seat { Name = txtName.Text });
                btn_C1.Content = myList[8].Name;
                MessageBox.Show("Seat reserved!");
                buttonC1WasClicked = false;
                btn_C1.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }
            else if (buttonC2WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(9);
                myList.Insert(9, new Seat { Name = txtName.Text });
                btn_C2.Content = myList[9].Name;
                MessageBox.Show("Seat reserved!");
                buttonC2WasClicked = false;
                btn_C2.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (buttonC3WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(10);
                myList.Insert(10, new Seat { Name = txtName.Text });
                btn_C3.Content = myList[10].Name;
                MessageBox.Show("Seat reserved!");
                buttonC3WasClicked = false;
                btn_C3.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (buttonC4WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(11);
                myList.Insert(11, new Seat { Name = txtName.Text });
                btn_C4.Content = myList[11].Name;
                MessageBox.Show("Seat reserved!");
                buttonC4WasClicked = false;
                btn_C4.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (buttonD1WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(12);
                myList.Insert(12, new Seat { Name = txtName.Text });
                btn_D1.Content = myList[12].Name;
                MessageBox.Show("Seat reserved!");
                buttonC1WasClicked = false;
                btn_D1.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }
            else if (buttonD2WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(13);
                myList.Insert(13, new Seat { Name = txtName.Text });
                btn_D2.Content = myList[13].Name;
                MessageBox.Show("Seat reserved!");
                buttonD2WasClicked = false;
                btn_D2.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (buttonD3WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(14);
                myList.Insert(14, new Seat { Name = txtName.Text });
                btn_D3.Content = myList[14].Name;
                MessageBox.Show("Seat reserved!");
                buttonD3WasClicked = false;
                btn_D3.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            else if (buttonD4WasClicked == true && txtName.Text != "")
            {
                myList.RemoveAt(15);
                myList.Insert(15, new Seat { Name = txtName.Text });
                btn_D4.Content = myList[15].Name;
                MessageBox.Show("Seat reserved!");
                buttonD4WasClicked = false;
                btn_D4.IsEnabled = false;
                btnUnreserveSeat.IsEnabled = true;
            }

            CheckSeats();
            txtName.Text = "";

        }
        private void ShowInstructions()
        {
            recGreen.Visibility = Visibility.Visible;
            recYellow.Visibility = Visibility.Visible;
            recGrey.Visibility = Visibility.Visible;
            lblAvailable.Visibility = Visibility.Visible;
            lblInstructions.Visibility = Visibility.Visible;
            lblSelected.Visibility = Visibility.Visible;
            lblUnavailable.Visibility = Visibility.Visible;
        }
        private void CheckSeats()
        {
            if (btn_A1.IsEnabled == false && btn_A2.IsEnabled == false && btn_A3.IsEnabled == false
                && btn_A4.IsEnabled == false && btn_B1.IsEnabled == false && btn_B2.IsEnabled == false
                && btn_B3.IsEnabled == false && btn_B4.IsEnabled == false && btn_C1.IsEnabled == false && btn_C2.IsEnabled == false
                && btn_C3.IsEnabled == false && btn_C4.IsEnabled == false && btn_D1.IsEnabled == false && btn_D2.IsEnabled == false
                && btn_D3.IsEnabled == false && btn_D4.IsEnabled == false)
            {
                lblReservedSeats.Content = seats.ToString();
            }
            else
            {
                lblReservedSeats.Content = "";
            }
        }

        private void CheckSeatsReservedString()
        {
            string name = txtName.Text;
            string element = "";

            for (int i = 0; i < myList.Count; i++)
            {

                if (string.Equals(myList[i].Name, name))
                {
                    element = myList[i].Name;
                    if (string.Equals(btn_A1.Content.ToString(), element))
                    {
                        myList.Insert(0, new Seat { Number = "A1" });
                        btn_A1.Content = "A1";
                        btn_A1.IsEnabled = true;
                        btn_A1.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_A1.Visibility = Visibility.Hidden;
                        btn_clearA1.Visibility = Visibility.Hidden;
                    }
                    else if (string.Equals(btn_A2.Content.ToString(), element))
                    {
                        myList.Insert(1, new Seat { Number = "A2" });
                        btn_A2.Content = "A2";
                        btn_A2.IsEnabled = true;
                        btn_A2.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_A2.Visibility = Visibility.Hidden;
                        btn_clearA2.Visibility = Visibility.Hidden;
                    }

                    else if (string.Equals(btn_A3.Content.ToString(), element))
                    {
                        myList.Insert(2, new Seat { Number = "A3" });
                        btn_A3.Content = "A3";
                        btn_A3.IsEnabled = true;
                        btn_A3.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_A3.Visibility = Visibility.Hidden;
                        btn_clearA3.Visibility = Visibility.Hidden;
                    }

                    else if (string.Equals(btn_A4.Content.ToString(), element))
                    {
                        myList.Insert(3, new Seat { Number = "A4" });
                        btn_A4.Content = "A4";
                        btn_A4.IsEnabled = true;
                        btn_A4.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_A4.Visibility = Visibility.Hidden;
                        btn_clearA4.Visibility = Visibility.Hidden;
                    }

                    else if (btn_B1.Content.ToString() == element)
                    {
                        myList.Insert(4, new Seat { Number = "B1" });
                        btn_B1.Content = "B1";
                        btn_B1.IsEnabled = true;
                        btn_B1.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_B1.Visibility = Visibility.Hidden;
                        btn_clearB1.Visibility = Visibility.Hidden;
                    }
                    else if (btn_B2.Content.ToString() == element)
                    {
                        myList.Insert(5, new Seat { Number = "B2" });
                        btn_B2.Content = "B2";
                        btn_B2.IsEnabled = true;
                        btn_B2.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_B2.Visibility = Visibility.Hidden;
                        btn_clearB2.Visibility = Visibility.Hidden;

                    }

                    else if (btn_B3.Content.ToString() == element)
                    {
                        myList.Insert(6, new Seat { Number = "B3" });
                        btn_B3.Content = "B3";
                        btn_B3.IsEnabled = true;
                        btn_B3.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_B3.Visibility = Visibility.Hidden;
                        btn_clearB3.Visibility = Visibility.Hidden;
                    }

                    else if (btn_B4.Content.ToString() == element)
                    {
                        myList.Insert(7, new Seat { Number = "B4" });
                        btn_B4.Content = "B4";
                        btn_B4.IsEnabled = true;
                        btn_B4.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_B4.Visibility = Visibility.Hidden;
                        btn_clearB4.Visibility = Visibility.Hidden;
                    }
                    else if (btn_C1.Content.ToString() == element)
                    {
                        myList.Insert(8, new Seat { Number = "C1" });
                        btn_C1.Content = "C1";
                        btn_C1.IsEnabled = true;
                        btn_C1.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_C1.Visibility = Visibility.Hidden;
                        btn_clearC1.Visibility = Visibility.Hidden;
                    }
                    else if (btn_C2.Content.ToString() == element)
                    {
                        myList.Insert(9, new Seat { Number = "C2" });
                        btn_C2.Content = "C2";
                        btn_C2.IsEnabled = true;
                        btn_C2.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_C2.Visibility = Visibility.Hidden;
                        btn_clearC2.Visibility = Visibility.Hidden;
                    }

                    else if (btn_C3.Content.ToString() == element)
                    {
                        myList.Insert(10, new Seat { Number = "C3" });
                        btn_C3.Content = "C3";
                        btn_C3.IsEnabled = true;
                        btn_C3.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_C3.Visibility = Visibility.Hidden;
                        btn_clearC3.Visibility = Visibility.Hidden;
                    }

                    else if (btn_C4.Content.ToString() == element)
                    {
                        myList.Insert(11, new Seat { Number = "C4" });
                        btn_C4.Content = "C4";
                        btn_C4.IsEnabled = true;
                        btn_C4.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_C4.Visibility = Visibility.Hidden;
                        btn_clearC4.Visibility = Visibility.Hidden;
                    }

                    else if (btn_D1.Content.ToString() == element)
                    {
                        myList.Insert(12, new Seat { Number = "D1" });
                        btn_D1.Content = "D1";
                        btn_D1.IsEnabled = true;
                        btn_D1.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_D1.Visibility = Visibility.Hidden;
                        btn_clearD1.Visibility = Visibility.Hidden;
                    }
                    else if (btn_D2.Content.ToString() == element)
                    {
                        myList.Insert(13, new Seat { Number = "D2" });
                        btn_D2.Content = "D2";
                        btn_D2.IsEnabled = true;
                        btn_D2.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_D2.Visibility = Visibility.Hidden;
                        btn_clearD2.Visibility = Visibility.Hidden;
                    }

                    else if (btn_D3.Content.ToString() == element)
                    {
                        myList.Insert(14, new Seat { Number = "D3" });
                        btn_D3.Content = "D3";
                        btn_D3.IsEnabled = true;
                        btn_D3.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_D3.Visibility = Visibility.Hidden;
                        btn_clearD3.Visibility = Visibility.Hidden;
                    }

                    else if (btn_D4.Content.ToString() == element)
                    {
                        myList.Insert(15, new Seat { Number = "D4" });
                        btn_D4.Content = "D4";
                        btn_D4.IsEnabled = true;
                        btn_D4.Background = Brushes.GreenYellow;
                        MessageBox.Show("Seat is clear!");
                        btn_D4.Visibility = Visibility.Hidden;
                        btn_clearD4.Visibility = Visibility.Hidden;
                    }
                }
            }
        }




        private void Btn_Reserve_Seat_Click(object sender, RoutedEventArgs e)
        {
            ShowInstructions();
            txtName.Clear();
            lblName.Visibility = Visibility.Visible;

            seatsZtoA.Visibility = Visibility.Hidden;
            btnDisplayLength.Visibility = Visibility.Hidden;
            serialize.Visibility = Visibility.Hidden;
            deserialize.Visibility = Visibility.Hidden;
            dataGrid1.Visibility = Visibility.Hidden;
            availableSeatList.Visibility = Visibility.Hidden;

            btn_clearA1.Visibility = Visibility.Hidden;
            btn_clearA2.Visibility = Visibility.Hidden;
            btn_clearA3.Visibility = Visibility.Hidden;
            btn_clearA4.Visibility = Visibility.Hidden;
            btn_clearB1.Visibility = Visibility.Hidden;
            btn_clearB2.Visibility = Visibility.Hidden;
            btn_clearB3.Visibility = Visibility.Hidden;
            btn_clearB4.Visibility = Visibility.Hidden;
            btn_clearC1.Visibility = Visibility.Hidden;
            btn_clearC2.Visibility = Visibility.Hidden;
            btn_clearC3.Visibility = Visibility.Hidden;
            btn_clearC4.Visibility = Visibility.Hidden;
            btn_clearD1.Visibility = Visibility.Hidden;
            btn_clearD2.Visibility = Visibility.Hidden;
            btn_clearD3.Visibility = Visibility.Hidden;
            btn_clearD4.Visibility = Visibility.Hidden;

            btn_clearAll.Visibility = Visibility.Hidden;
            btnUnreserveSeat.IsEnabled = true;
            btnReserveSeat.IsEnabled = false;
            btnDelete.Visibility = Visibility.Hidden;
            btnConfirmSeat.Visibility = Visibility.Visible;
            txtName.Visibility = Visibility.Visible;

            btn_A1.Visibility = Visibility.Visible;
            btn_A2.Visibility = Visibility.Visible;
            btn_A3.Visibility = Visibility.Visible;
            btn_A4.Visibility = Visibility.Visible;
            btn_B1.Visibility = Visibility.Visible;
            btn_B2.Visibility = Visibility.Visible;
            btn_B3.Visibility = Visibility.Visible;
            btn_B4.Visibility = Visibility.Visible;
            btn_C1.Visibility = Visibility.Visible;
            btn_C2.Visibility = Visibility.Visible;
            btn_C3.Visibility = Visibility.Visible;
            btn_C4.Visibility = Visibility.Visible;
            btn_D1.Visibility = Visibility.Visible;
            btn_D2.Visibility = Visibility.Visible;
            btn_D3.Visibility = Visibility.Visible;
            btn_D4.Visibility = Visibility.Visible;

        }
        private void Btn_Unreserve_Seat_Click(object sender, RoutedEventArgs e)
        {
           
            
            txtName.Text = string.Empty;
            MessageBox.Show("Please delete a reservation by typing a name and pressing delete or pressing clear");

            ShowInstructions();

            seatsZtoA.Visibility = Visibility.Hidden;
            btnDisplayLength.Visibility = Visibility.Hidden;
            serialize.Visibility = Visibility.Hidden;
            deserialize.Visibility = Visibility.Hidden;
            dataGrid1.Visibility = Visibility.Hidden;
            availableSeatList.Visibility = Visibility.Hidden;

            txtName.Visibility = Visibility.Visible;

            btn_clearA1.Visibility = Visibility.Visible;
            btn_clearA2.Visibility = Visibility.Visible;
            btn_clearA3.Visibility = Visibility.Visible;
            btn_clearA4.Visibility = Visibility.Visible;
            btn_clearB1.Visibility = Visibility.Visible;
            btn_clearB2.Visibility = Visibility.Visible;
            btn_clearB3.Visibility = Visibility.Visible;
            btn_clearB4.Visibility = Visibility.Visible;
            btn_clearC1.Visibility = Visibility.Visible;
            btn_clearC2.Visibility = Visibility.Visible;
            btn_clearC3.Visibility = Visibility.Visible;
            btn_clearC4.Visibility = Visibility.Visible;
            btn_clearD1.Visibility = Visibility.Visible;
            btn_clearD2.Visibility = Visibility.Visible;
            btn_clearD3.Visibility = Visibility.Visible;
            btn_clearD4.Visibility = Visibility.Visible;

            btn_clearAll.Visibility = Visibility.Visible;
            btnReserveSeat.IsEnabled = true;
            btnUnreserveSeat.IsEnabled = false;
            btnDelete.Visibility = Visibility.Visible;
            btnConfirmSeat.Visibility = Visibility.Hidden;

            if (btn_A1.IsEnabled == true)
            {
                btn_A1.Visibility = Visibility.Hidden;
                btn_clearA1.Visibility = Visibility.Hidden;
            }

            if (btn_A2.IsEnabled == true)
            {
                btn_A2.Visibility = Visibility.Hidden;
                btn_clearA2.Visibility = Visibility.Hidden;
            }

            if (btn_A3.IsEnabled == true)
            {
                btn_A3.Visibility = Visibility.Hidden;
                btn_clearA3.Visibility = Visibility.Hidden;
            }

            if (btn_A4.IsEnabled == true)
            {
                btn_A4.Visibility = Visibility.Hidden;
                btn_clearA4.Visibility = Visibility.Hidden;
            }

            if (btn_B1.IsEnabled == true)
            {
                btn_B1.Visibility = Visibility.Hidden;
                btn_clearB1.Visibility = Visibility.Hidden;
            }

            if (btn_B2.IsEnabled == true)
            {
                btn_B2.Visibility = Visibility.Hidden;
                btn_clearB2.Visibility = Visibility.Hidden;
            }

            if (btn_B3.IsEnabled == true)
            {
                btn_B3.Visibility = Visibility.Hidden;
                btn_clearB3.Visibility = Visibility.Hidden;
            }

            if (btn_B4.IsEnabled == true)
            {
                btn_B4.Visibility = Visibility.Hidden;
                btn_clearB4.Visibility = Visibility.Hidden;
            }

            if (btn_C1.IsEnabled == true)
            {
                btn_C1.Visibility = Visibility.Hidden;
                btn_clearC1.Visibility = Visibility.Hidden;
            }

            if (btn_C2.IsEnabled == true)
            {
                btn_C2.Visibility = Visibility.Hidden;
                btn_clearC2.Visibility = Visibility.Hidden;
            }

            if (btn_C3.IsEnabled == true)
            {
                btn_C3.Visibility = Visibility.Hidden;
                btn_clearC3.Visibility = Visibility.Hidden;
            }

            if (btn_C4.IsEnabled == true)
            {
                btn_C4.Visibility = Visibility.Hidden;
                btn_clearC4.Visibility = Visibility.Hidden;
            }

            if (btn_D1.IsEnabled == true)
            {
                btn_D1.Visibility = Visibility.Hidden;
                btn_clearD1.Visibility = Visibility.Hidden;
            }

            if (btn_D2.IsEnabled == true)
            {
                btn_D2.Visibility = Visibility.Hidden;
                btn_clearD2.Visibility = Visibility.Hidden;
            }

            if (btn_D3.IsEnabled == true)
            {
                btn_D3.Visibility = Visibility.Hidden;
                btn_clearD3.Visibility = Visibility.Hidden;
            }

            if (btn_D4.IsEnabled == true)
            {
                btn_D4.Visibility = Visibility.Hidden;
                btn_clearD4.Visibility = Visibility.Hidden;
            }




        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Insert the correct name");
            }
            else
            {
                CheckSeatsReservedString();
            }
            CheckSeats();
            txtName.Text = "";
        }



        private void Btn_A1_Click(object sender, RoutedEventArgs e)
        {
            button1WasClicked = true;

            btnUnreserveSeat.IsEnabled = false;
            if (button1WasClicked == true)
            {
                btn_A1.Background = Brushes.Yellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;


            }
        }




        private void Btn_A2_Click(object sender, RoutedEventArgs e)
        {
            button2WasClicked = true;
            if (button2WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.Yellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }
        private void Btn_A3_Click(object sender, RoutedEventArgs e)
        {
            button3WasClicked = true;
            if (button3WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.Yellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }
        private void Btn_A4_Click(object sender, RoutedEventArgs e)
        {
            button4WasClicked = true;
            if (button4WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.Yellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_B1_Click(object sender, RoutedEventArgs e)
        {
            buttonB1WasClicked = true;
            if (buttonB1WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.Yellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_B2_Click(object sender, RoutedEventArgs e)
        {
            buttonB2WasClicked = true;
            if (buttonB2WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.Yellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_B3_Click(object sender, RoutedEventArgs e)
        {
            buttonB3WasClicked = true;
            if (buttonB3WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.Yellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;


                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_B4_Click(object sender, RoutedEventArgs e)
        {
            buttonB4WasClicked = true;
            if (buttonB4WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.Yellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_C1_Click(object sender, RoutedEventArgs e)
        {
            buttonC1WasClicked = true;
            if (buttonC1WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.Yellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_C2_Click(object sender, RoutedEventArgs e)
        {
            buttonC2WasClicked = true;
            if (buttonC2WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.Yellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_C3_Click(object sender, RoutedEventArgs e)
        {
            buttonC3WasClicked = true;
            if (buttonC3WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.Yellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_C4_Click(object sender, RoutedEventArgs e)
        {
            buttonC4WasClicked = true;
            if (buttonC4WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.Yellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_D1_Click(object sender, RoutedEventArgs e)
        {
            buttonD1WasClicked = true;
            if (buttonD1WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.Yellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;


                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_D2_Click(object sender, RoutedEventArgs e)
        {
            buttonD2WasClicked = true;
            if (buttonD2WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.Yellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD3WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_D3_Click(object sender, RoutedEventArgs e)
        {
            buttonD3WasClicked = true;
            if (buttonD3WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.Yellow;
                btn_D4.Background = Brushes.GreenYellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD4WasClicked = false;
            }

        }

        private void Btn_D4_Click(object sender, RoutedEventArgs e)
        {
            buttonD4WasClicked = true;
            if (buttonD4WasClicked == true)
            {
                btn_A1.Background = Brushes.GreenYellow;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A4.Background = Brushes.GreenYellow;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B4.Background = Brushes.GreenYellow;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C4.Background = Brushes.GreenYellow;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D4.Background = Brushes.Yellow;

                button1WasClicked = false;
                button2WasClicked = false;
                button3WasClicked = false;
                button4WasClicked = false;
                buttonB1WasClicked = false;
                buttonB2WasClicked = false;
                buttonB3WasClicked = false;
                buttonB4WasClicked = false;
                buttonC1WasClicked = false;
                buttonC2WasClicked = false;
                buttonC3WasClicked = false;
                buttonC4WasClicked = false;
                buttonD1WasClicked = false;
                buttonD2WasClicked = false;
                buttonD3WasClicked = false;
            }

        }

        
   
        private void Btn_clearA1_Click(object sender, RoutedEventArgs e)
        {
            if (btn_A1.IsEnabled == false)
            {
                string element = "";
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_A1.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_A1.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_A1.Content = "A1";
                            btn_A1.IsEnabled = true;
                            btn_A1.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat A1 is clear!");
                            btn_A1.Visibility = Visibility.Hidden;
                            btn_clearA1.Visibility = Visibility.Hidden;
                            myList.Insert(0, new Seat { Number = "A1" });
                        }
                    }
                }
            }


            else
            {
                MessageBox.Show("Seat is already available");
            }

            CheckSeats();
        }

        private void Btn_clearA2_Click(object sender, RoutedEventArgs e)
        {
            if (btn_A2.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_A2.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_A2.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_A2.Content = "A2";
                            btn_A2.IsEnabled = true;
                            btn_A2.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat A2 is clear!");
                            btn_A2.Visibility = Visibility.Hidden;
                            btn_clearA2.Visibility = Visibility.Hidden;
                            myList.Insert(1, new Seat { Number = "A2" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }


        private void Btn_clearA3_Click(object sender, RoutedEventArgs e)
        {
            if (btn_A3.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_A3.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_A3.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_A3.Content = "A3";
                            btn_A3.IsEnabled = true;
                            btn_A3.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat A3 is clear!");
                            btn_A3.Visibility = Visibility.Hidden;
                            btn_clearA3.Visibility = Visibility.Hidden;
                            myList.Insert(2, new Seat { Number = "A3" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearA4_Click(object sender, RoutedEventArgs e)
        {
            if (btn_A4.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_A4.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_A4.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_A4.Content = "A4";
                            btn_A4.IsEnabled = true;
                            btn_A4.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat A4 is clear!");
                            btn_A4.Visibility = Visibility.Hidden;
                            btn_clearA4.Visibility = Visibility.Hidden;
                            myList.Insert(3, new Seat { Number = "A4" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearB1_Click(object sender, RoutedEventArgs e)
        {
            if (btn_B1.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_B1.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_B1.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_B1.Content = "B1";
                            btn_B1.IsEnabled = true;
                            btn_B1.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat B1 is clear!");
                            btn_B1.Visibility = Visibility.Hidden;
                            btn_B1.Visibility = Visibility.Hidden;
                            btn_clearB1.Visibility = Visibility.Hidden;
                            myList.Insert(5, new Seat { Number = "B1" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearB2_Click(object sender, RoutedEventArgs e)
        {
            if (btn_B2.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_B2.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_B2.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_B2.Content = "B2";
                            btn_B2.IsEnabled = true;
                            btn_B2.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat B2 is clear!");
                            btn_B2.Visibility = Visibility.Hidden;
                            btn_clearB2.Visibility = Visibility.Hidden;
                            myList.Insert(6, new Seat { Number = "B2" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearB3_Click(object sender, RoutedEventArgs e)
        {
            if (btn_B3.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_B3.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_B3.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_B3.Content = "B3";
                            btn_B3.IsEnabled = true;
                            btn_B3.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat B3 is clear!");
                            btn_B3.Visibility = Visibility.Hidden;
                            btn_clearB3.Visibility = Visibility.Hidden;
                            myList.Insert(7, new Seat { Number = "B3" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearB4_Click(object sender, RoutedEventArgs e)
        {
            if (btn_B4.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_B4.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_B4.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_B4.Content = "B4";
                            btn_B4.IsEnabled = true;
                            btn_B4.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat B4 is clear!");
                            btn_B4.Visibility = Visibility.Hidden;
                            btn_clearB4.Visibility = Visibility.Hidden;
                            myList.Insert(8, new Seat { Number = "B4" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        
        private void Btn_clearC1_Click(object sender, RoutedEventArgs e)
        {
            if (btn_C1.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";
                string button = btn_C1.Content.ToString();
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_C1.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_C1.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_C1.Content = "C1";
                            btn_C1.IsEnabled = true;
                            btn_C1.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat C1 is clear!");
                            btn_C1.Visibility = Visibility.Hidden;
                            btn_clearC1.Visibility = Visibility.Hidden;
                            myList.Insert(9, new Seat { Number = "C1" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearC2_Click(object sender, RoutedEventArgs e)
        {
            if (btn_C2.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_C2.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_C2.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_C2.Content = "C2";
                            btn_C2.IsEnabled = true;
                            btn_C2.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat C2 is clear!");
                            btn_C2.Visibility = Visibility.Hidden;
                            btn_clearC2.Visibility = Visibility.Hidden;
                            myList.Insert(10, new Seat { Number = "C2" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearC3_Click(object sender, RoutedEventArgs e)
        {
            if (btn_C3.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_C3.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_C3.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_C3.Content = "C3";
                            btn_C3.IsEnabled = true;
                            btn_C3.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat C3 is clear!");
                            btn_C3.Visibility = Visibility.Hidden;
                            btn_clearC3.Visibility = Visibility.Hidden;
                            myList.Insert(10, new Seat { Number = "C3" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearC4_Click(object sender, RoutedEventArgs e)
        {
            if (btn_C4.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_C4.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_C4.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_C4.Content = "C4";
                            btn_C4.IsEnabled = true;
                            btn_C4.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat C4 is clear!");
                            btn_C4.Visibility = Visibility.Hidden;
                            btn_clearC4.Visibility = Visibility.Hidden;
                            myList.Insert(11, new Seat { Number = "C4" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }


        private void Btn_clearD1_Click(object sender, RoutedEventArgs e)
        {
            if (btn_D1.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";
                string button = btn_D1.Content.ToString();
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_D1.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_D1.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_D1.Content = "D1";
                            btn_D1.IsEnabled = true;
                            btn_D1.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat D1 is clear!");
                            btn_D1.Visibility = Visibility.Hidden;
                            btn_clearD1.Visibility = Visibility.Hidden;
                            myList.Insert(12, new Seat { Number = "D1" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearD2_Click(object sender, RoutedEventArgs e)
        {
            if (btn_D2.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_D2.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_D2.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_D2.Content = "D2";
                            btn_D2.IsEnabled = true;
                            btn_D2.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat D2 is clear!");
                            btn_D2.Visibility = Visibility.Hidden;
                            btn_clearD2.Visibility = Visibility.Hidden;
                            myList.Insert(13, new Seat { Number = "D2" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearD3_Click(object sender, RoutedEventArgs e)
        {
            if (btn_D3.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_D3.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_D3.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_D3.Content = "D3";
                            btn_D3.IsEnabled = true;
                            btn_D3.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat D3 is clear!");
                            btn_D3.Visibility = Visibility.Hidden;
                            btn_clearD3.Visibility = Visibility.Hidden;
                            myList.Insert(14, new Seat { Number = "D3" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }
            CheckSeats();
        }

        private void Btn_clearD4_Click(object sender, RoutedEventArgs e)
        {
            if (btn_D4.IsEnabled == false)
            {
                string name = txtName.Text;
                string element = "";

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Name.Contains(btn_D4.Content.ToString()))
                    {
                        element = myList[i].Name;
                        if (btn_D4.Content.ToString() == element)
                        {
                            myList.RemoveAt(i);
                            btn_D4.Content = "D4";
                            btn_D4.IsEnabled = true;
                            btn_D4.Background = Brushes.GreenYellow;
                            MessageBox.Show("Seat D4 is clear!");
                            btn_D4.Visibility = Visibility.Hidden;
                            btn_clearD4.Visibility = Visibility.Hidden;
                            myList.Insert(15, new Seat { Number = "D4" });
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Seat is already available");
            }          
            CheckSeats();
        }


        private void Btn_ClearAll(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Do you wish to clear all seats?", "Clear Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {

                for (int i = myList.Count - 1; i >= 0; i--)
                {

                        myList.RemoveAt(i);
                }

                btn_A1.Content = "A1";
                btn_A1.IsEnabled = true;
                btn_A1.Background = Brushes.GreenYellow;
                btn_A1.Visibility = Visibility.Hidden;
                btn_clearA1.Visibility = Visibility.Hidden;

                btn_A2.Content = "A2";
                btn_A2.IsEnabled = true;
                btn_A2.Background = Brushes.GreenYellow;
                btn_A2.Visibility = Visibility.Hidden;
                btn_clearA2.Visibility = Visibility.Hidden;

                btn_A3.Content = "A3";
                btn_A3.IsEnabled = true;
                btn_A3.Background = Brushes.GreenYellow;
                btn_A3.Visibility = Visibility.Hidden;
                btn_clearA3.Visibility = Visibility.Hidden;

                btn_A4.Content = "A4";
                btn_A4.IsEnabled = true;
                btn_A4.Background = Brushes.GreenYellow;
                btn_A4.Visibility = Visibility.Hidden;
                btn_clearA4.Visibility = Visibility.Hidden;

                btn_B1.Content = "B1";
                btn_B1.IsEnabled = true;
                btn_B1.Background = Brushes.GreenYellow;
                btn_B1.Visibility = Visibility.Hidden;
                btn_clearB1.Visibility = Visibility.Hidden;

                btn_B2.Content = "B2";
                btn_B2.IsEnabled = true;
                btn_B2.Background = Brushes.GreenYellow;
                btn_B2.Visibility = Visibility.Hidden;
                btn_clearB2.Visibility = Visibility.Hidden;

                btn_B3.Content = "B3";
                btn_B3.IsEnabled = true;
                btn_B3.Background = Brushes.GreenYellow;
                btn_B3.Visibility = Visibility.Hidden;
                btn_clearB3.Visibility = Visibility.Hidden;

                btn_B4.Content = "B4";
                btn_B4.IsEnabled = true;
                btn_B4.Background = Brushes.GreenYellow;
                btn_B4.Visibility = Visibility.Hidden;
                btn_clearB4.Visibility = Visibility.Hidden;

                btn_C1.Content = "C1";
                btn_C1.IsEnabled = true;
                btn_C1.Background = Brushes.GreenYellow;
                btn_C1.Visibility = Visibility.Hidden;
                btn_clearC1.Visibility = Visibility.Hidden;

                btn_C2.Content = "C2";
                btn_C2.IsEnabled = true;
                btn_C2.Background = Brushes.GreenYellow;
                btn_C2.Visibility = Visibility.Hidden;
                btn_clearC2.Visibility = Visibility.Hidden;

                btn_C3.Content = "C3";
                btn_C3.IsEnabled = true;
                btn_C3.Background = Brushes.GreenYellow;
                btn_C3.Visibility = Visibility.Hidden;
                btn_clearC3.Visibility = Visibility.Hidden;

                btn_C4.Content = "C4";
                btn_C4.IsEnabled = true;
                btn_C4.Background = Brushes.GreenYellow;
                btn_C4.Visibility = Visibility.Hidden;
                btn_clearC4.Visibility = Visibility.Hidden;

                btn_D1.Content = "D1";
                btn_D1.IsEnabled = true;
                btn_D1.Background = Brushes.GreenYellow;
                btn_D1.Visibility = Visibility.Hidden;
                btn_clearD1.Visibility = Visibility.Hidden;

                btn_D2.Content = "D2";
                btn_D2.IsEnabled = true;
                btn_D2.Background = Brushes.GreenYellow;
                btn_D2.Visibility = Visibility.Hidden;
                btn_clearD2.Visibility = Visibility.Hidden;

                btn_D3.Content = "D3";
                btn_D3.IsEnabled = true;
                btn_D3.Background = Brushes.GreenYellow;
                btn_D3.Visibility = Visibility.Hidden;
                btn_clearD3.Visibility = Visibility.Hidden;

                btn_D4.Content = "D4";
                btn_D4.IsEnabled = true;
                btn_D4.Background = Brushes.GreenYellow;
                btn_D4.Visibility = Visibility.Hidden;
                btn_clearD4.Visibility = Visibility.Hidden;

                myList.Insert(0, new Seat { Number = "A1" });
                myList.Insert(1, new Seat { Number = "A2" });
                myList.Insert(2, new Seat { Number = "A3" });
                myList.Insert(3, new Seat { Number = "A4" });
                myList.Insert(4, new Seat { Number = "B1" });
                myList.Insert(5, new Seat { Number = "B2" });
                myList.Insert(6, new Seat { Number = "B3" });
                myList.Insert(7, new Seat { Number = "B4" });
                myList.Insert(8, new Seat { Number = "C1" });
                myList.Insert(9, new Seat { Number = "C2" });
                myList.Insert(10, new Seat { Number = "C3" });
                myList.Insert(11, new Seat { Number = "C4" });
                myList.Insert(12, new Seat { Number = "D1" });
                myList.Insert(13, new Seat { Number = "D2" });
                myList.Insert(14, new Seat { Number = "D3" });
                myList.Insert(15, new Seat { Number = "D4" });
            }
            MessageBox.Show("All seats are clear");
            CheckSeats();
        }
        private void Button_Seats_ZtoA(object sender, RoutedEventArgs e)
        {
            var seatQuery = myList.OrderByDescending(seat => seat.Name).GroupBy(seat => seat.Name);
            foreach (var seat in seatQuery)
            {
                dataGrid1.ItemsSource = seatQuery.ToList();
            }
        }

        private void Button_List_By_Length(object sender, RoutedEventArgs e)
        {
            var seatQuery = myList.OrderBy(seat => seat.Name.Length).GroupBy(seat => seat.Name);
                
            foreach (var seat in seatQuery)
            {
                dataGrid1.ItemsSource = seatQuery.ToList();
            }
        }

        private void Button_List_Available_Seats(object sender, RoutedEventArgs e)
        {
            var seatQuery = myList.OrderBy(seat => seat.Number).GroupBy(seat => seat.Number);
            foreach(var seat in seatQuery)
            {
                dataGrid1.ItemsSource = seatQuery.ToList();
            }         
        }

        private void Button_Serialize(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var stream = new FileStream("seat.xml", FileMode.Create))
                {
                    var XML = new XmlSerializer(typeof(List<Seat>));
                    XML.Serialize(stream, myList);
                    MessageBox.Show("XML file serialized!");
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }
        }

        

        private void Button_Deserialize(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Seat>));
                XmlReader reader = XmlReader.Create("seat.xml");
                myList = (List<Seat>)serializer.Deserialize(reader);
                MessageBox.Show("XML file deserialized!");
                dataGrid1.ItemsSource = myList.ToList();
                reader.Close();

            }
            catch (IOException)
            {
            }
        }

        private void Button_List_Seats(object sender, RoutedEventArgs e)
        {
            btnReserveSeat.IsEnabled = true;
            btnUnreserveSeat.IsEnabled = true;
            seatsZtoA.Visibility = Visibility.Visible;
            btnDisplayLength.Visibility = Visibility.Visible;
            serialize.Visibility = Visibility.Visible;
            deserialize.Visibility = Visibility.Visible;
            dataGrid1.Visibility = Visibility.Visible;
            availableSeatList.Visibility = Visibility.Visible;

            btn_clearA1.Visibility = Visibility.Hidden;
            btn_clearA2.Visibility = Visibility.Hidden;
            btn_clearA3.Visibility = Visibility.Hidden;
            btn_clearA4.Visibility = Visibility.Hidden;
            btn_clearB1.Visibility = Visibility.Hidden;
            btn_clearB2.Visibility = Visibility.Hidden;
            btn_clearB3.Visibility = Visibility.Hidden;
            btn_clearB4.Visibility = Visibility.Hidden;
            btn_clearC1.Visibility = Visibility.Hidden;
            btn_clearC2.Visibility = Visibility.Hidden;
            btn_clearC3.Visibility = Visibility.Hidden;
            btn_clearC4.Visibility = Visibility.Hidden;
            btn_clearD1.Visibility = Visibility.Hidden;
            btn_clearD2.Visibility = Visibility.Hidden;
            btn_clearD3.Visibility = Visibility.Hidden;
            btn_clearD4.Visibility = Visibility.Hidden;

            btn_A1.Visibility = Visibility.Hidden;
            btn_A2.Visibility = Visibility.Hidden;
            btn_A3.Visibility = Visibility.Hidden;
            btn_A4.Visibility = Visibility.Hidden;
            btn_B1.Visibility = Visibility.Hidden;
            btn_B2.Visibility = Visibility.Hidden;
            btn_B3.Visibility = Visibility.Hidden;
            btn_B4.Visibility = Visibility.Hidden;
            btn_C1.Visibility = Visibility.Hidden;
            btn_C2.Visibility = Visibility.Hidden;
            btn_C3.Visibility = Visibility.Hidden;
            btn_C4.Visibility = Visibility.Hidden;
            btn_D1.Visibility = Visibility.Hidden;
            btn_D2.Visibility = Visibility.Hidden;
            btn_D3.Visibility = Visibility.Hidden;
            btn_D4.Visibility = Visibility.Hidden;

            btnDelete.Visibility = Visibility.Hidden;
            btnConfirmSeat.Visibility = Visibility.Hidden;

            btn_clearAll.Visibility = Visibility.Hidden;
            txtName.Visibility = Visibility.Hidden;
            lblName.Visibility = Visibility.Hidden;
            lblAvailable.Visibility = Visibility.Hidden;
            lblInstructions.Visibility = Visibility.Hidden;
            lblReservedSeats.Visibility = Visibility.Hidden;
            lblSelected.Visibility = Visibility.Hidden;
            lblUnavailable.Visibility = Visibility.Hidden;
            recGreen.Visibility = Visibility.Hidden; 
            recYellow.Visibility = Visibility.Hidden;
            recGrey.Visibility = Visibility.Hidden;
        }   
    }
}