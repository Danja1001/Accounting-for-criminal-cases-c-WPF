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
    public partial class LawyerFreeCases : Form
    {
        private readonly IRepository _repository;
        public LawyerFreeCases(Lawyer lawyer)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += LawyerFreeCases_Load;
            LawyerId.Text = lawyer.Id.ToString();
        }

        private void LawyerFreeCases_Load(object sender, EventArgs e)
        {
            var cases = _repository.Of<Case>()
                .GetAll().ToArray();

            //SELECT Id FROM Case WHERE EndDate == null;

            foreach (var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id, @case.Title, @case.StartDate, @case.EndDate);
            }
        }

        private void InfoLawyerBtn_Click(object sender, EventArgs e)
        {
         
        }

        private void CasesGridEditor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                if(e.RowIndex < 0)
                {
                    MessageBox.Show("This column is a button.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                var caseId = (int)CasesGridEditor.Rows[e.RowIndex].Cells[0].Value;
                int lawyerId = int.Parse(LawyerId.Text);
                var lawyer = _repository.Of<Lawyer>().GetById(lawyerId); //SELECT Id FROM Lawyer WHERE Id = lawyerId;
                var @case = _repository.Of<Case>().GetById(caseId); //SELECT Id FROM Case WHERE Id = caseId;

                if (e.ColumnIndex == 4)
                {
                    lawyer.Cases.Add(@case);
                    _repository.SaveChanges();

                    MessageBox.Show("The Case successfull taken.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                CaseInfo caseInfo = new CaseInfo(lawyer,@case);
                caseInfo.ShowDialog();
            }
        }

        private void FreeCases_Click(object sender, EventArgs e)
        {
            FreeCasesLbl.Text = "Free Cases";

            var cases = _repository.Of<Case>()
                .Search(x => x.EndDate == null)
                .ToArray();

            //SELECT Id FROM Case WHERE EndDate == null;
            CasesGridEditor.Rows.Clear();
            foreach (var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id, @case.Title, @case.StartDate, @case.EndDate);
            }
        }

        private void CaseAll_Click(object sender, EventArgs e)
        {
            FreeCasesLbl.Text = "All Cases";
            var cases = _repository.Of<Case>()
                .GetAll().ToArray();

            //SELECT Id FROM Case WHERE EndDate == null;
            CasesGridEditor.Rows.Clear();

            foreach (var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id, @case.Title, @case.StartDate, @case.EndDate);
            }
        }

        private void LawyerFreeCases_Load_1(object sender, EventArgs e)
        {

        }
    }
}