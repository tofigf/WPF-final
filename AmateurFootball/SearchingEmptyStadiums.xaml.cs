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
    /// Interaction logic for SearchingEmptyStadiums.xaml
    /// </summary>
    public partial class SearchingEmptyStadiums : UserControl
    {
        FootballEntities db = new FootballEntities();
        Reserve reserve = new Reserve();
        public SearchingEmptyStadiums()
        {
            InitializeComponent();
            FillDataGrid();
        }
        public class ReservedView
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
        }

        private void txtDays_TextChanged(object sender, TextChangedEventArgs e)
        {
          //  this.reserve =db.Reserves.FirstOrDefault(r=>r.ReserervAcsessDate==txtDays.Text)
        }

        private void txtHours_TextChanged(object sender, TextChangedEventArgs e)
        {
            ReservedView rest = dpSeach.DataContext as ReservedView;
            if (rest != null)
            {
                //this.rest = db.Reserves.Where(r => r.STime == txtHours.Text).ToList();
            }
           
        }
        private void FillDataGrid()
        {
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
                    Phone = item.Costumer.Phone.ToString()
                };
                dgSearchResult.Items.Add(obj);
            }
        }

        private void dpSeach_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)

        {


        }

       
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            ReservedView rest = dpSeach.DataContext as ReservedView;
            if (rest != null)
            {
                //this.rest = db.Reserves.Where(r => r.ReserervAcsessDate.Value.Date == dpSeach.SelectedDate.Value.Date).ToList();
            }
            MessageBox.Show(dpSeach.SelectedDate.Value.Date.ToShortDateString());
        }
    }
}
