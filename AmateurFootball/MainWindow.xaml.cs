using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AmateurFootball.Model;

namespace AmateurFootball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FootballEntities db = new FootballEntities();
        Stadium stadium = new Stadium();
        Model.Reserve reserve = new Model.Reserve();
        int clickRow;
        int end;
        // ComboBox data = new ComboBox();
        public MainWindow()
        {
            InitializeComponent();
            FillStadiumNames();
            FillDgreserved();
         
          Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

        //  public static IObservable<MainWindow>.getReservedView()
        class ReservedView
        {
            public int Id { get; set; }
            public string Stadium { get; set; }
            public string Stime { get; set; }
            public string Etime { get; set; }
            public DateTime ReservAcsesstime { get; set; }
            public string Price { get; set; }
            public string Costumer { get; set; }
            public string Phone { get; set; }
            public string Reverces { get; set; }
            public DateTime MatchDate { get; set; }

        }
        class StadiumView
        {
            public int StadiumId { get; set; }
            public string Stadium { get; set; }
            public string Stime { get; set; }
            public string Etime { get; set; }
            public string Costumer { get; set; }
            public string Phone { get; set; }
            public DateTime Date { get; set; }
            public string Price { get; set; }
        }
        //instace almaga caliwdim
        class Pick_Item
        {
            private ComboBoxItem _comboSelection;

            public Pick_Item(ComboBoxItem comboSelection)
            {
                _comboSelection = comboSelection;
            }
        }
        class Order
        {
            public int Size { get; set; }
        }
        private void FillStadiumNames()//stadionu doldurmaq
        {
            foreach (Stadium item in db.Stadiums.ToList())
            {
                cmbStadium.Items.Add(item.Id+ "-"+  item.Name);
            }
        }
        private void cmbStadium_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }
        private void FillDgreserved()//datagridi doldurmaq
        {
            foreach (Reserve item in db.Reserves.OrderByDescending(o=>o.ReserervAcsessDate).ToList())
            {
                var obj = new ReservedView
                {
                    Id = item.Id,
                    Stadium = item.Stadium.Name,
                    Stime = item.STime,
                    Etime = item.Etime,
                    ReservAcsesstime = item.ReserervAcsessDate.Value,
                   Price =((decimal)item.Price).ToString("#.##"),
                   Costumer =item.Costumer.FullName,
                   Phone =item.Costumer.Phone.ToString(),
                   MatchDate =item.MatchDate.Value.Date
                };
             dgReserv.Items.Add(obj);
            }
        }
        private void cmbTest_Loaded(object sender, RoutedEventArgs e)// Start comboboxu doldurmaq
        {
            List<string> data = new List<string>();
            for (int i = 9; i <= 24; i++)
            {
                data.Add(i + ":" + "00".ToString());

                var comboBox = sender as ComboBox;
                comboBox.ItemsSource = data;
                //  comboBox.SelectedIndex = 0;

            }
            //Pick_Item pi = new Pick_Item(data);
            //pi.Show();
        }
        private void cmbTest_SelectionChanged(object sender, SelectionChangedEventArgs e)//Start comboboxa selectini deyiwende baw veren
        {
            var comboBox = sender as ComboBox;
            // ... Set SelectedItem as Window Title.
            string value = comboBox.SelectedItem as string;
            if (value != null)
            {
                this.Title = "Selected:" + value;
                string[] values = value.Split(':');
            
                tbPrice.Text = "";

                if (Convert.ToInt32(values[0]) <= 14)
                {
                    tbPrice.Text = "30-Azn";
                    return;
                }
                else if (Convert.ToInt32(values[0]) <= 20)
                {
                    tbPrice.Text = "40-Azn";
                    return;
                }
                else if (Convert.ToInt32(values[0]) >= 20)
                {
                    tbPrice.Text = "60-Azn";
                    return;
                }
            }
        }
        private void cmbETimeTest_Loaded(object sender, RoutedEventArgs e)//End comboboxu doldurmaq
        {
            List<string> data = new List<string>();
            for (int i = 9; i <= 24; i++)
            {
                data.Add(i + ":" + "00".ToString());
            }
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            // comboBox.SelectedIndex = 0;
        }
        private void cmbETimeTest_SelectionChanged(object sender, SelectionChangedEventArgs e)//End comboboxun selectideyiwende baw veren
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            this.Title = "Selected: " + value;
           // MessageBox.Show(value);
        }
        private void FindStadiumIDByName()
        {
            Reserve rserv = cmbTest.SelectedItem as Reserve;
            if (rserv != null)
            {
                end = db.Reserves.FirstOrDefault(r => r.Stadium.Name == cmbTest.Text).Id;
            }
              
        }
        private void Button_Click(object sender, RoutedEventArgs e)//add etmek booking button
        {
            dgReserv.Items.Clear();
            lblError.Text = "";
            string stime = cmbTest.Text;
            string etime = cmbETimeTest.Text;
            string costumer = txtCostumers.Text;
            string phone = txtPhone.Text;
            FindStadiumIDByName();

            if (cmbStadium.Text == string.Empty || stime == string.Empty || etime == string.Empty || costumer == string.Empty )
            {
                lblError.Text = "Butun xanalari doldurun";
                return;
            }
            if (!decimal.TryParse(phone, out decimal Phone))
            {
                lblError.Text = "Sayı düzgün yazın";
                return;
            }


            //foreach (Reserve item in db.Reserves.ToList())
            //{
            //    if (item.StadiumId == end &&
            //        item.MatchDate.Value.Date == dpMatchDate.SelectedDate.Value.Date &&
            //        (Convert.ToInt32(item.STime.Split(':')[0]) <= Convert.ToInt32(cmbTest.Text.Split(':')[0])) && (Convert.ToInt32(item.Etime.Split(':')[0]) >= Convert.ToInt32(cmbTest.Text.Split(':')[0])) ||
            //        (Convert.ToInt32(item.STime.Split(':')[0]) <= Convert.ToInt32(cmbETimeTest.Text.Split(':')[0])) && (Convert.ToInt32(item.Etime.Split(':')[0]) >= Convert.ToInt32(cmbETimeTest.Text.Split(':')[0]))||
            //        (Convert.ToInt32(item.STime.Split(':')[0]) >= Convert.ToInt32(cmbTest.Text.Split(':')[0])) && (Convert.ToInt32(item.Etime.Split(':')[0]) <= Convert.ToInt32(cmbTest.Text.Split(':')[0])) ||
            //          (Convert.ToInt32(item.STime.Split(':')[0]) >= Convert.ToInt32(cmbETimeTest.Text.Split(':')[0])) && (Convert.ToInt32(item.Etime.Split(':')[0]) <= Convert.ToInt32(cmbETimeTest.Text.Split(':')[0]))
            //        )
            //    {
            //        MessageBox.Show("duz");
            //        return;
            //        //lblError.Text = "Start time must be small than End";
            //    }
            //    else
            //    {
            //        if (cmbTest.Text != cmbETimeTest.Text&& (Convert.ToInt32(item.Etime.Split(':')[0])) > (Convert.ToInt32(item.STime.Split(':')[0])))
            //        {
                       
            //        }
                 
            //    }
            //}

         
            Reserve reserved = new Reserve
            {

                StadiumId = Convert.ToInt32(cmbStadium.Text.Split('-')[0]),
                STime = stime,
                Etime = etime,
                ReserervAcsessDate = DateTime.Now,
                Price = Convert.ToDecimal(tbPrice.Text.Split('-')[0]),
                CostumerId = this.reserve.CostumerId,
                MatchDate = dpMatchDate.SelectedDate.Value.Date

            };
            db.Reserves.Add(reserved);

            Costumer cost = new Costumer
            {
                FullName = costumer,
                Phone = Convert.ToInt32(phone)
            };

            db.Costumers.Add(cost);
            db.SaveChanges();
            Reset();
            dgReserv.Items.Clear();
            FillDgreserved();//datagridi yeniden doldurmaq
            // this.reserve = null;
        }
        private void Reset()
        {
            cmbStadium.Text = "";
            cmbTest.Text = "";
            cmbETimeTest.Text = "";
            txtCostumers.Text = "";
            txtPhone.Text = "";
            
          

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)  //DELETE
        {

            var selectedItem = dgReserv.SelectedItem;
            if (selectedItem != null)
            {
               
                dgReserv.Items.Remove(selectedItem);
            }
          
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)//UPDATE
        {
            lblError.Text = "";
            string stadium = cmbStadium.Text;
            string stime = cmbTest.Text;
            string etime = cmbETimeTest.Text;
            string costumer = txtCostumers.Text;
            string phone = txtPhone.Text;
            string price = tbPrice.Text;
            if (cmbStadium.Text == string.Empty || stime == string.Empty || etime == string.Empty || costumer == string.Empty)
            {
                lblError.Text = "Butun xanalari doldurun";
                return;
            }
            if (!int.TryParse(phone, out int Phone))
            {
                lblError.Text = "Sayı düzgün yazın";
                return;
            }
            if (!decimal.TryParse(price.Split('-')[0], out decimal Price))
            {
                lblError.Text = "Sayı düzgün yazın";
                return;
            }
        
            ReservedView rest = dgReserv.CurrentItem as ReservedView;
            
            Reserve res = db.Reserves.Find(clickRow);
         
                if (rest != null)
                {
                    res.StadiumId = Convert.ToInt32(cmbStadium.Text.Split('-')[0]);
                    res.STime = cmbTest.Text;
                    res.Etime = cmbETimeTest.Text;
                    res.ReserervAcsessDate = DateTime.Now;
                    res.Costumer.FullName = txtCostumers.Text;
                    res.Costumer.Phone = Convert.ToInt32(phone);
                    res.Price = Convert.ToDecimal(price.Split('-')[0]);
                    res.MatchDate = dpMatchDate.SelectedDate.Value.Date;
                    db.SaveChanges();
                    Reset();
                    dgReserv.Items.Clear();
                    FillDgreserved();//datagridi yeniden doldurmaq
               }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) //search button
        {
            //foreach (ReservedView item in db.Reserves.Where(r=>r.MatchDate.ToShortDateString())
            //{
            //}
            //  ReservedView rest = dgReserv.SelectedItem as ReservedView;
          //  Reserve r = new Reserve();
            foreach (ReservedView rest in dgReserv.Items)
            {
                string starttime = rest.Stime;
                string endtime = rest.Etime;
                string date = rest.MatchDate.ToShortDateString();
                //   MessageBox.Show(starttime + " " + endtime + " " + sname);
            if(rest != null)
            {
                if (dpSearch.Text == rest.MatchDate.Date.ToShortDateString())
                {
                    //   dgReserv.Items.Remove(sname);
                    // MessageBox.Show(date);
                    foreach (Reserve item in db.Reserves.OrderByDescending(o => o.ReserervAcsessDate).ToList())
                    {
                        var obj = new ReservedView
                        {
                            Id = item.Id,
                            Stadium = item.Stadium.Name,
                            Stime = item.STime,
                            Etime = item.Etime,
                            ReservAcsesstime = item.ReserervAcsessDate.Value,
                            Price = ((decimal)item.Price).ToString("#.##"),
                            Costumer = item.Costumer.FullName,
                            Phone = item.Costumer.Phone.ToString(),
                            MatchDate = item.MatchDate.Value.Date
                        };

                        dgSearch.Items.Add(obj);
                    }
                }
                         }
                        //}
                        //  var selects = dgReserv.SelectedItems;
                        //if(selects != null)
                        //{
                        //    dgReserv.SelectedItems.Remove(selects);
                        //}
                        //for (int i = dgReserv.SelectedItems.Count - 1; i >= 0; i--)
                        //{
                        //    dgReserv.SelectedItems.Remove()
                        }
                //        foreach (var item in db.Reserves.ToList())
                //{
                //   // MessageBox.Show(item.MatchDate.ToString());
                //  // clickRow= dgReserv.Visibility=false;

                

                  
                //foreach (DataGridViewRow item in others.ToList())
                //{
                //    dgvStocks.Rows[item.Index].Visible = false;
            
        }
            private void dgReserv_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e) //datagrid click edende secilenleri doldurmaq
        {
            ReservedView rest = dgReserv.CurrentItem as ReservedView;
            clickRow = rest.Id;
          //  MessageBox.Show(clickRow.ToString());
            if (rest != null)
            {
                reserve = db.Reserves.Find(rest.Id);
                cmbStadium.Text = reserve.Stadium.Name;
                cmbTest.Text = reserve.STime;
                cmbETimeTest.Text = reserve.Etime;
                txtCostumers.Text = reserve.Costumer.FullName;
                txtPhone.Text = reserve.Costumer.Phone.ToString();
                dpMatchDate.Text = reserve.MatchDate.Value.ToShortDateString();
            }
        }
    }
}
