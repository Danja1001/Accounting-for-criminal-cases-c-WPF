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
    public partial class LawyerCase : Form
    {
        private readonly IRepository _repository;
        public LawyerCase(int lawyerId)
        {
            _repository = RepositoryFactory.Create();
            InitializeComponent();
            Load += LawyerCase_Load;

            var cases = _repository.Of<Case>()
                .Search(x => x.Lawyers.Any(y => y.Id == lawyerId))
                .ToArray();
            foreach(var @case in cases)
            {
                CasesGridEditor.Rows.Add(@case.Id, lawyerId, @case.Title, @case.StartDate, @case.EndDate);
            }
        }
        private void LawyerCase_Load(object sender, EventArgs e)
        {
           
        }

        private void LawyerCase_Load_1(object sender, EventArgs e)
        {

        }

        private void CasesGridEditor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("This column is a button.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                var caseId = (int)CasesGridEditor.Rows[e.RowIndex].Cells[0].Value;
                var lawyerId = (int)CasesGridEditor.Rows[e.RowIndex].Cells[1].Value;

                LawyerCaseInfo lawyerCaseInfo = new LawyerCaseInfo(caseId, lawyerId);
                lawyerCaseInfo.ShowDialog();
            }
        }
    }
}
