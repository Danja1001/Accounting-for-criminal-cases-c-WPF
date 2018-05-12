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
    public partial class LawyerForm : Form
    {
        private readonly IRepository _repository;
        public LawyerForm(DomainModel.Lawyer lawyer)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += LawyerForm_Load;
            LawyerIdTxt.Text = lawyer.Id.ToString();
            LawyerNameLabel.Text = lawyer.FirstName;
            LawyerLastNameLabel.Text = lawyer.LastName;
        }

        private void LawyerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LawyerCaseBtn_Click(object sender, EventArgs e)
        {
            int lawyerId = int.Parse(LawyerIdTxt.Text);

            var lawyer = _repository.Of<Lawyer>().GetById(lawyerId);
            if(lawyer != null)
            {
                LawyerFreeCases lawyerFreeCases = new LawyerFreeCases(lawyer);
                lawyerFreeCases.ShowDialog();
            }
           
        }

        private void AllCaseBtn_Click(object sender, EventArgs e)
        {
            int lawyerId = int.Parse(LawyerIdTxt.Text);
            LawyerCase lawyerCase = new LawyerCase(lawyerId);
            lawyerCase.ShowDialog();
        }

        private void LawyerNameEditBtn_Click(object sender, EventArgs e)
        {
            int lawyerId = int.Parse(LawyerIdTxt.Text);

            var lawyer = _repository.Of<Lawyer>().GetById(lawyerId);


            if (lawyer != null)
            {
                Hide();
                LawyerEdit lawyerEdit = new LawyerEdit(lawyer);
                lawyerEdit.ShowDialog();
            }
        }
    }
}
