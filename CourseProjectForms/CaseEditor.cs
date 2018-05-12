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
    public partial class CaseEditor : Form
    {
        private readonly IRepository _repository;
        public CaseEditor()
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += CaseEditor_Load;
        }

        private void CaseEditor_Load(object sender, EventArgs e)
        {
            var cases = _repository.Of<Case>().GetAll().ToArray();
            
            foreach(var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id,@case.Title, @case.StartDate, @case.EndDate);
            }
        }

        private void AddNewCaseBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddNewCase addNewCase = new AddNewCase();
            addNewCase.ShowDialog();
        }

        private void CasesGridEditor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if(e.RowIndex < 0)
                {
                    MessageBox.Show("This column is a button.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                Hide();
                var CaseId = (int)CasesGridEditor.Rows[e.RowIndex].Cells[0].Value;
                CaseEdit lawyerEdit = new CaseEdit(CaseId);
                lawyerEdit.ShowDialog();
            }
        }

        private void LawyerEditorBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminViewForm adminViewForm = new AdminViewForm();
            adminViewForm.ShowDialog();
        }

        private void CaseComplete_Click(object sender, EventArgs e)
        {
            var cases = _repository.Of<Case>()
                .Search(x => x.EndDate != null)
                .ToArray();

            CasesGridEditor.Rows.Clear();
            foreach (var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id, @case.Title, @case.StartDate, @case.EndDate);
            }
        }

        private void CasesEditorBtn_Click(object sender, EventArgs e)
        {
            var cases = _repository.Of<Case>().GetAll().ToArray();

            CasesGridEditor.Rows.Clear();
            foreach (var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id, @case.Title, @case.StartDate, @case.EndDate);
            }
        }

        private void CaseFree_Click(object sender, EventArgs e)
        {
            CasesGridEditor.Rows.Clear();

            var cases = _repository.Of<Case>()
                .Search(x => x.EndDate == null)
                .ToArray();

            foreach(var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id, @case.Title, @case.StartDate, @case.EndDate);
            }
        }
    }
}
