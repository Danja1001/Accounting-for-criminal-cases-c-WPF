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
    public partial class LawyerEdit : Form
    {
        private readonly IRepository _repository;
        public LawyerEdit(DomainModel.Lawyer lawyer)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += LawyerEdit_Load;
            LawyerId.Text = lawyer.Id.ToString();
            FirstNameEditTxt.Text = lawyer.FirstName;
            LastNameEditTxt.Text = lawyer.LastName;
        }

        private void LawyerEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void LawyerSaveData_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(LawyerId.Text);

            var lawyer = _repository.Of<Lawyer>()
               .Search(x => x.Id == Id)
               .FirstOrDefault();

            if(lawyer != null)
            {
                lawyer.FirstName = FirstNameEditTxt.Text;
                lawyer.LastName = LastNameEditTxt.Text;

                _repository.SaveChanges();

                MessageBox.Show("The lawyer was successfully edited.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Hide();
                LawyerForm lawyerForm = new LawyerForm(lawyer);
                lawyerForm.ShowDialog();
            } else
            {
                MessageBox.Show("Could not edit this lawyer.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BackAdmin_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(LawyerId.Text);

            var lawyer = _repository.Of<Lawyer>().GetById(Id);
            Hide();
            LawyerForm lawyerForm = new LawyerForm(lawyer);
            lawyerForm.ShowDialog();
        }
    }
}
