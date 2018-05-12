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
    public partial class EditLawyer : Form
    {
        private readonly IRepository _repository;

        public EditLawyer(int lawyerId)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += EditLawyer_Load;

            var lawyer = _repository.Of<Lawyer>().GetById(lawyerId);


            LawyerIdHidden.Text = lawyer.Id.ToString();
            FirstNameEditText.Text = lawyer.FirstName;
            LastNameEditText.Text = lawyer.LastName;
            LawyerEmailTxt.Text = lawyer.Email;
            LawyerPasswordTxt.Text = lawyer.Password;
            DateOfBirthEditPicker.Value = lawyer.DateOfBirth;
        }

        private void EditLawyer_Load(object sender, EventArgs e)
        {

        }

        private void EditLawyerBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(LawyerIdHidden.Text);

            var lawyer = _repository.Of<Lawyer>()
                .Search(x => x.Id == id)
                .FirstOrDefault();


            if(lawyer != null)
            {
                lawyer.FirstName = FirstNameEditText.Text;
                lawyer.LastName = LastNameEditText.Text;
                lawyer.Email = LawyerEmailTxt.Text;
                lawyer.Password = LawyerPasswordTxt.Text.Sha256();
                lawyer.DateOfBirth = DateOfBirthEditPicker.Value;
                _repository.SaveChanges();

                MessageBox.Show("The lawyer was successfully edited.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Hide();
                AdminViewForm adminViewForm = new AdminViewForm();
                adminViewForm.ShowDialog();
            } else
            {
                MessageBox.Show("Could not edit this lawyer.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BackAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            AdminViewForm adminViewForm = new AdminViewForm();
            adminViewForm.ShowDialog();
        }

        private void LawyerDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(LawyerIdHidden.Text);
            var lawyer = _repository.Of<Lawyer>().GetById(id);

            var @case = _repository.Of<Case>()
                .Search(x => x.Lawyers.Any(y => y.Id == id))
                .Count();

            if(@case > 0)
            {
                MessageBox.Show("Lawyer busy!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _repository.Of<Lawyer>().Delete(lawyer);
            _repository.SaveChanges();

            MessageBox.Show("The lawyer was successfully deleted.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Hide();
            AdminViewForm adminViewForm = new AdminViewForm();
            adminViewForm.ShowDialog();
        }
    }
}
