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
    public partial class LogInForm : Form
    {
        private readonly IRepository _repository;

        public LogInForm()
        {
            _repository = RepositoryFactory.Create();

            //GET

           // var lawyers = _repository.Of<Lawyer>().GetAll().ToArray();

            ////INSERT
            //var lawyer = new Lawyer
            //{
            //    FirstName = "Kostiantyn",
            //    LastName = "Kuda-----",
            //    DateOfBirth = new DateTime(1983, 7, 24)
            //};


            //_repository.Of<Lawyer>().Insert(lawyer);
            //_repository.SaveChanges();




            ////UPDATE
            //var lawyer = _repository.Of<Lawyer>()
            //                        .Search(x => x.LastName == "Kuda-----")
            //                        .FirstOrDefault();

            //if (lawyer != null)
            //{
            //    lawyer.LastName = "Kuda";
            //}

            //_repository.SaveChanges();



            ////Add To collection
            //var kuda = _repository.Of<Lawyer>()
            //                      .GetById(1);

            //var @case = new Case
            //{
            //    Title = "Fuckin bullshit",
            //    Description = "Nein",
            //    StartDate = DateTime.Now,
                
            //};

            //kuda.Cases.Add(@case); 

            //_repository.SaveChanges();

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            var adminUserName = ConfigurationManager.AppSettings["admin:userName"];
            var adminUserPassword = ConfigurationManager.AppSettings["admin:password"];


            string username = UsrNameTxt.Text;
            string password = UsrPasswordTxt.Text;

            if(username == adminUserName && password.Sha256() == adminUserPassword)
            {
                AdminViewForm adminViewForm = new AdminViewForm();
                adminViewForm.ShowDialog();
            }
            else
            {
                password = password.Sha256();
                var lawyer = _repository.Of<Lawyer>()
                 .Search(x => x.Email == username && x.Password == password)
                 .SingleOrDefault();

                if(lawyer != null)
                {
                    LawyerForm lawyerForm = new LawyerForm(lawyer);
                    lawyerForm.ShowDialog();
                } else
                {
                    MessageBox.Show("Invalid user. Please, try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            
        }

        private void UsrPasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsrNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
