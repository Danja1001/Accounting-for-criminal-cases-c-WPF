using System;
using System.Configuration;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using CourseProjectForms.DB;
using CourseProjectForms.DB.Interfaces;
using CourseProjectForms.DomainModel;
using CourseProjectForms.Extensions;

namespace CourseProjectForms
{
    public partial class OnClickAdd : Form
    {

        private readonly IRepository _repository;
        public OnClickAdd()
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
        }

        private void AddLawyerBtn_Click(object sender, EventArgs e)
        {
            var FirstName = FirstNameText.Text;
            var LastName = LastNameText.Text;
            var Email = LawyerEmailTxt.Text;
            var Password = LawyerPasswordTxt.Text;
            var DateOfBirth = DateOfBirthPicker.Value;


           if(String.IsNullOrWhiteSpace(FirstName))
            {
                MessageBox.Show("First name required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(LastName))
            {
                MessageBox.Show("Last name required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Email required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Password required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var lawyer = new Lawyer
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Password = Password.Sha256(),
                DateOfBirth = DateOfBirth
            };

            _repository.Of<Lawyer>().Insert(lawyer);
            _repository.SaveChanges();
            MessageBox.Show("Lawyer successfull add!","OK!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Hide();
            AdminViewForm adminView = new AdminViewForm();
            adminView.ShowDialog();
        }

        private void OnClickAdd_Load(object sender, EventArgs e)
        {

        }

        private void BackAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            AdminViewForm adminViewForm = new AdminViewForm();
            adminViewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
