using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RENTAL_PROJECT_LAB_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Car> cars = new List<Car>();
        List<user> users = new List<user>();

        private void usersavebutton_Click(object sender, EventArgs e)
        {
            user dummy_user = new user();
            dummy_user.UserID = useridtextbox.Text;
            dummy_user.UserName = usernametextbox.Text;
            dummy_user.Address = addresstextbox.Text;
            dummy_user.Destination = destinationtextbox.Text;

            users.Add(dummy_user);

            MessageBox.Show("User Info Saved Successfully");



        }

        private void carsavebutton_Click(object sender, EventArgs e)
        {


            Car dummy_Car = new Car();
            dummy_Car.CarName = carnametextbox.Text;
            dummy_Car.CarModel = carmodeltextbox.Text;
            dummy_Car.CarNumber = carnumbertextbox.Text;

            cars.Add(dummy_Car);
            MessageBox.Show("Car Info Saved Successfully");


        }

        private void carhistorybutton_Click(object sender, EventArgs e)
        {
            string search_car_name = carnamehistorytextbox.Text;
            foreach (Car Car in cars)
            {
                if (Car.CarName == search_car_name)

                {
                    availableunitcarhistorylabel.Text = "Available Unit:" + Car.CarNumber;
                    carmodelcarhistorylabel.Text = "Model:" + Car.CarModel; }
            }
        }

        private void userhistorybutton_Click(object sender, EventArgs e)
        {
            string search_id = useridhistorytextbox.Text;
            foreach (user user in users)
            {
                usernameuserhistorylabel.Text = "User Name:" + user.UserName;
                addressuserhistorylabel.Text = "Address:" + user.Address;
                rentedcaruserhistorylabel.Text = "Rented Car:" + user.UserRentCar;
                destinationuserhistorylabel.Text = "Destination:" + user.Destination;

            }
        }

        private void rentbutton_Click(object sender, EventArgs e)
        {
            string rent_user_id = useridrenttextbox.Text;
            string rent_car = carnamerenttextbox.Text;
            foreach (user user in users)
            {
                if (user.UserID == rent_user_id)
                {
                    foreach (Car Car in cars)
                    {
                        if (Car.CarName == rent_car)
                        {
                            user.UserRentCar = rent_car;
                            int a = Convert.ToInt32(Car.CarNumber);
                            a = a-1;
                            Car.CarNumber = Convert.ToString(a);
                            MessageBox.Show("This Car is rented for this User");
                            break;

                        }
                    }
                }
            }
        }
    }
   
        
         
}
