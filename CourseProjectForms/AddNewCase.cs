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
    public partial class AddNewCase : Form
    {
        private readonly IRepository _repository;
        public AddNewCase()
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
        }

        private void CaseAddBtn_Click(object sender, EventArgs e)
        {
            var title = CaseTitleTxt.Text;
            var description = CaseDescriptionTxt.Text;
            var startDate = CaseStartPicker.Value;
            
            if(String.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title required","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var @case = new Case
            {
                Title = title,
                Description = description,
                StartDate = startDate
            };

            _repository.Of<Case>().Insert(@case);
            _repository.SaveChanges();
            MessageBox.Show("Case successfull add!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Hide();
            CaseEditor caseEditor = new CaseEditor();
            caseEditor.ShowDialog();
        }

        private void BackCase_Click(object sender, EventArgs e)
        {
            Hide();
            CaseEditor caseEditor = new CaseEditor();
            caseEditor.ShowDialog();
        }
    }
}
